using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Configuration;
using FranklinSoft.RegCompare;
using FranklinSoft.RegCompare.Results;

namespace FranklinSoft.RegCompareDesktop
{
    public partial class Form1 : Form
    {
        private List<RegistryEntry> _machineARegistryEntries;
        private List<RegistryEntry> _machineBRegistryEntries;
        private List<RegistryEntry> _missingEntriesFromMachineB;
        private List<RegistryEntry> _missingEntriesFromMachineA;
        private List<RegistryEntryDifference> _registryEntryDifferences;
        private readonly int _testConnectionTimeout = Config.TestConnectionTimeout;
        private readonly int _retrieveRegistryTimeout = Config.RetrieveRegistryTimeout;
        private readonly string _defaultRegistryKeyRoot = Config.DefaultRegistryKeyRoot;
        private readonly string _defaultMachineA = Config.DefaultMachineA;
        private readonly string _defaultMachineB = Config.DefaultMachineB;
        public Form1()
        {
            InitializeComponent();
            lbl_MachineALoading.Visible = false;
            lbl_MachineBLoading.Visible = false;
            _machineARegistryEntries = new List<RegistryEntry>();
            _machineBRegistryEntries = new List<RegistryEntry>();
            _missingEntriesFromMachineB = new List<RegistryEntry>();
            _missingEntriesFromMachineA = new List<RegistryEntry>();
            _registryEntryDifferences = new List<RegistryEntryDifference>();
            dataGridView1.BackgroundColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView2.BackgroundColor = dataGridView2.DefaultCellStyle.BackColor;
            dataGridView3.BackgroundColor = dataGridView3.DefaultCellStyle.BackColor;
            dataGridView4.BackgroundColor = dataGridView4.DefaultCellStyle.BackColor;
            dataGridView5.BackgroundColor = dataGridView5.DefaultCellStyle.BackColor;

            combobox_registryHive.DataSource = Enum.GetValues(typeof(RegistryHive));
            combobox_registryHive.SelectedIndex = 1;

            textbox_registryKeyRoot.Text = Config.DefaultRegistryKeyRoot;
            textBox_machineAName.Text = Config.DefaultMachineA;
            textBox_machineBName.Text = Config.DefaultMachineB;


        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            RegistryHive registryHive = (RegistryHive)combobox_registryHive.SelectedItem;

            var testConnectionA = TestConnection(textBox_machineAName.Text, lbl_MachineALoading, tokenSource, token);
            var testConnectionB = TestConnection(textBox_machineBName.Text, lbl_MachineBLoading, tokenSource, token);
            await Task.WhenAny(Task.WhenAll(new List<Task>() { testConnectionA, testConnectionB }));

            if (!token.IsCancellationRequested)
            {
                var t1 = GetRegisty(registryHive, textBox_machineAName.Text, lbl_MachineALoading, tokenSource, token);
                var t2 = GetRegisty(registryHive, textBox_machineBName.Text, lbl_MachineBLoading, tokenSource, token);
                await Task.WhenAny(Task.WhenAll(new List<Task>() { t1, t2 }));
                _machineARegistryEntries = t1.Result;
                _machineBRegistryEntries = t2.Result;
            }

            if (!token.IsCancellationRequested)
            {
                PopulateRegistryTable(lbl_MachineALoading, dataGridView1, _machineARegistryEntries);
                PopulateRegistryTable(lbl_MachineBLoading, dataGridView2, _machineBRegistryEntries);
            }

            if (!token.IsCancellationRequested)
                await PopulateTabs();

        }

        private async Task TestConnection(string machineName, Label machineLabel, CancellationTokenSource tokenSource, CancellationToken token)
        {
            machineLabel.Text = "Testing Connection";
            machineLabel.Visible = true;

            Task<bool> testConnection = Task<bool>.Factory.StartNew(() =>
            {
                machineLabel.Text = "Testing Connection";
                TestConnectionResult result = RegistryCompare.TestConnection(machineName);
                return result.Successful;
            }, tokenSource.Token);
            if (await Task.WhenAny(testConnection, Task.Delay(_testConnectionTimeout, token)) == testConnection)
            {
                await testConnection;
            }
            else
            {
                machineLabel.Text = "Connection Timedout";
            }
            if (!testConnection.Result)
            {
                try
                {

                    tokenSource.Cancel();
                    token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException) { machineLabel.Text = "Connection Failed"; }
            }
            else
            {
                machineLabel.Text = "Connection Successful";
            }
        }

        private async Task<List<RegistryEntry>> GetRegisty(RegistryHive registryHive, string machineName, Label machineLabel, CancellationTokenSource tokenSource, CancellationToken token)
        {
            machineLabel.Text = "Loading Registry";
            machineLabel.Visible = true;
            Task<List<RegistryEntry>> regKeysMachine = Task<List<RegistryEntry>>.Factory.StartNew(() =>
            {
                RegistryEntriesResult result = RegistryCompare.GetRegistryEntries(registryHive, textbox_registryKeyRoot.Text, machineName);
                return result.RegistryEntries;
            }, tokenSource.Token);
            if (await Task.WhenAny(regKeysMachine, Task.Delay(_retrieveRegistryTimeout, token)) == regKeysMachine)
            {
                await regKeysMachine;
                machineLabel.Text = "Loaded";
                return regKeysMachine.Result;
            }
            else
            {
                try
                {
                    tokenSource.Cancel();
                    token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException)
                {
                    machineLabel.Text = "Connection Failed: Timed out retreiving keys";
                }
            }
            return new List<RegistryEntry>();
        }

        private void PopulateRegistryTable(Label machineLabel, DataGridView dataGridView, List<RegistryEntry> machineRegistryEntries)
        {
            machineLabel.Text = "Populating Table";
            machineLabel.Visible = true;
            if (machineRegistryEntries.Count <= 0)
            {
                machineLabel.Text = "There are no items under the specified key";
            }
            DataTable table = CreateDataTable(machineRegistryEntries);
            dataGridView.DataSource = table;

            SetColumnProperties(dataGridView);
            StretchLastColumn(dataGridView);
            machineLabel.Text = "Done";
        }

        private async Task PopulateTabs()
        {
            _missingEntriesFromMachineB = RegistryCompare.FindMissingRegistryEntries(_machineARegistryEntries, _machineBRegistryEntries);
            PopulateTab(_missingEntriesFromMachineB, dataGridView3);

            _missingEntriesFromMachineA = RegistryCompare.FindMissingRegistryEntries(_machineBRegistryEntries, _machineARegistryEntries);
            PopulateTab(_missingEntriesFromMachineA, dataGridView4);

            _registryEntryDifferences = RegistryCompare.FindMatchingRegistryEntries(_machineARegistryEntries, _machineBRegistryEntries);
            PopulateTab(_registryEntryDifferences, dataGridView5);
        }

        private void PopulateTab<T>(IEnumerable<T> list, DataGridView dataGridView)
        {
            var table = CreateDataTable(list);
            dataGridView.DataSource = table;
            SetColumnProperties(dataGridView);
            StretchLastColumn(dataGridView);
        }

        public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name,
                    Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void btn_missingEntriesFromMachineB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Registry File|*.reg";
            saveFileDialog1.Title = "Save a Registry File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
                RegFileHandler.ExportMissingEntries(_missingEntriesFromMachineB, sw);
            }
        }

        private void btn_missingEntriesFromMachineA_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Registry File|*.reg";
            saveFileDialog1.Title = "Save a Registry File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
                RegFileHandler.ExportMissingEntries(_missingEntriesFromMachineA, sw);
            }
        }

        private void btn_matchingDifferences_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
                RegFileHandler.ExportMatchingDifferences(_registryEntryDifferences, sw);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox_machineAName.Text == _defaultMachineA)
            {
                textBox_machineAName.Text = string.Empty;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_machineAName.Text))
            {
                textBox_machineAName.Text = _defaultMachineA;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox_machineBName.Text == _defaultMachineB)
            {
                textBox_machineBName.Text = string.Empty;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_machineBName.Text))
            {
                textBox_machineBName.Text = _defaultMachineB;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textbox_registryKeyRoot.Text == _defaultRegistryKeyRoot)
            {
                textbox_registryKeyRoot.Text = string.Empty;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textbox_registryKeyRoot.Text))
            {
                textbox_registryKeyRoot.Text = _defaultRegistryKeyRoot;
            }
        }

        private void btn_missingEntriesFromMachineARefresh_Click(object sender, EventArgs e)
        {
            DataTable table = CreateDataTable(_missingEntriesFromMachineA);
            dataGridView4.DataSource = table;
        }

        private void btn_missingEntriesFromMachineBRefresh_Click(object sender, EventArgs e)
        {
            DataTable table = CreateDataTable(_missingEntriesFromMachineB);
            dataGridView3.DataSource = table;
        }

        private void btn_matchingDifferencesRefresh_Click(object sender, EventArgs e)
        {
            DataTable table = CreateDataTable(_registryEntryDifferences);
            dataGridView5.DataSource = table;
        }

        private void ClearDataTables()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView3.DataSource = null;
            dataGridView3.Refresh();
            dataGridView4.DataSource = null;
            dataGridView4.Refresh();
            dataGridView5.DataSource = null;
            dataGridView5.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void StretchLastColumn(DataGridView dataGridView)
        {
            var lastColIndex = dataGridView.Columns.Count - 1;
            var lastCol = dataGridView.Columns[lastColIndex];
            lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetColumnProperties(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = 200;
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
    }
}
