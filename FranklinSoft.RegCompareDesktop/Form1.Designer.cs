namespace FranklinSoft.RegCompareDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.s = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MachineB = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MissingEntriesFromMachineB = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_missingEntriesFromMachineBRefresh = new System.Windows.Forms.Button();
            this.btn_missingEntriesFromMachineB = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MissingEntriesFromMachineA = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_missingEntriesFromMachineARefresh = new System.Windows.Forms.Button();
            this.btn_missingEntriesFromMachineA = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.MatchingDifferences = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_matchingDifferencesRefresh = new System.Windows.Forms.Button();
            this.btn_matchingDifferences = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_registryKeyRoot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_machineBName = new System.Windows.Forms.TextBox();
            this.textBox_machineAName = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MachineALoading = new System.Windows.Forms.Label();
            this.lbl_MachineBLoading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combobox_registryHive = new System.Windows.Forms.ComboBox();
            this.registryHive_lbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MachineB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.MissingEntriesFromMachineB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.MissingEntriesFromMachineA.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.MatchingDifferences.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.s);
            this.tabControl1.Controls.Add(this.MachineB);
            this.tabControl1.Controls.Add(this.MissingEntriesFromMachineB);
            this.tabControl1.Controls.Add(this.MissingEntriesFromMachineA);
            this.tabControl1.Controls.Add(this.MatchingDifferences);
            this.tabControl1.Location = new System.Drawing.Point(12, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // s
            // 
            this.s.Controls.Add(this.dataGridView1);
            this.s.Location = new System.Drawing.Point(4, 22);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(3);
            this.s.Size = new System.Drawing.Size(767, 379);
            this.s.TabIndex = 0;
            this.s.Text = "MachineA";
            this.s.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(761, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // MachineB
            // 
            this.MachineB.Controls.Add(this.dataGridView2);
            this.MachineB.Location = new System.Drawing.Point(4, 22);
            this.MachineB.Name = "MachineB";
            this.MachineB.Padding = new System.Windows.Forms.Padding(3);
            this.MachineB.Size = new System.Drawing.Size(767, 379);
            this.MachineB.TabIndex = 1;
            this.MachineB.Text = "MachineB";
            this.MachineB.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.Size = new System.Drawing.Size(761, 357);
            this.dataGridView2.TabIndex = 0;
            // 
            // MissingEntriesFromMachineB
            // 
            this.MissingEntriesFromMachineB.Controls.Add(this.panel1);
            this.MissingEntriesFromMachineB.Controls.Add(this.dataGridView3);
            this.MissingEntriesFromMachineB.Location = new System.Drawing.Point(4, 22);
            this.MissingEntriesFromMachineB.Name = "MissingEntriesFromMachineB";
            this.MissingEntriesFromMachineB.Padding = new System.Windows.Forms.Padding(3);
            this.MissingEntriesFromMachineB.Size = new System.Drawing.Size(767, 379);
            this.MissingEntriesFromMachineB.TabIndex = 2;
            this.MissingEntriesFromMachineB.Text = "MissingEntriesFromMachineB";
            this.MissingEntriesFromMachineB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_missingEntriesFromMachineBRefresh);
            this.panel1.Controls.Add(this.btn_missingEntriesFromMachineB);
            this.panel1.Location = new System.Drawing.Point(567, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 3;
            // 
            // btn_missingEntriesFromMachineBRefresh
            // 
            this.btn_missingEntriesFromMachineBRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_missingEntriesFromMachineBRefresh.Location = new System.Drawing.Point(3, 0);
            this.btn_missingEntriesFromMachineBRefresh.Name = "btn_missingEntriesFromMachineBRefresh";
            this.btn_missingEntriesFromMachineBRefresh.Size = new System.Drawing.Size(75, 23);
            this.btn_missingEntriesFromMachineBRefresh.TabIndex = 2;
            this.btn_missingEntriesFromMachineBRefresh.Text = "Refresh";
            this.btn_missingEntriesFromMachineBRefresh.UseVisualStyleBackColor = true;
            this.btn_missingEntriesFromMachineBRefresh.Click += new System.EventHandler(this.btn_missingEntriesFromMachineBRefresh_Click);
            // 
            // btn_missingEntriesFromMachineB
            // 
            this.btn_missingEntriesFromMachineB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_missingEntriesFromMachineB.Location = new System.Drawing.Point(94, 0);
            this.btn_missingEntriesFromMachineB.Name = "btn_missingEntriesFromMachineB";
            this.btn_missingEntriesFromMachineB.Size = new System.Drawing.Size(75, 23);
            this.btn_missingEntriesFromMachineB.TabIndex = 1;
            this.btn_missingEntriesFromMachineB.Text = "Save";
            this.btn_missingEntriesFromMachineB.UseVisualStyleBackColor = true;
            this.btn_missingEntriesFromMachineB.Click += new System.EventHandler(this.btn_missingEntriesFromMachineB_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.Size = new System.Drawing.Size(761, 341);
            this.dataGridView3.TabIndex = 0;
            // 
            // MissingEntriesFromMachineA
            // 
            this.MissingEntriesFromMachineA.Controls.Add(this.panel2);
            this.MissingEntriesFromMachineA.Controls.Add(this.dataGridView4);
            this.MissingEntriesFromMachineA.Location = new System.Drawing.Point(4, 22);
            this.MissingEntriesFromMachineA.Name = "MissingEntriesFromMachineA";
            this.MissingEntriesFromMachineA.Size = new System.Drawing.Size(767, 379);
            this.MissingEntriesFromMachineA.TabIndex = 3;
            this.MissingEntriesFromMachineA.Text = "MissingEntriesFromMachineA";
            this.MissingEntriesFromMachineA.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_missingEntriesFromMachineARefresh);
            this.panel2.Controls.Add(this.btn_missingEntriesFromMachineA);
            this.panel2.Location = new System.Drawing.Point(567, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 23);
            this.panel2.TabIndex = 3;
            // 
            // btn_missingEntriesFromMachineARefresh
            // 
            this.btn_missingEntriesFromMachineARefresh.Location = new System.Drawing.Point(3, 0);
            this.btn_missingEntriesFromMachineARefresh.Name = "btn_missingEntriesFromMachineARefresh";
            this.btn_missingEntriesFromMachineARefresh.Size = new System.Drawing.Size(75, 23);
            this.btn_missingEntriesFromMachineARefresh.TabIndex = 2;
            this.btn_missingEntriesFromMachineARefresh.Text = "Refresh";
            this.btn_missingEntriesFromMachineARefresh.UseVisualStyleBackColor = true;
            this.btn_missingEntriesFromMachineARefresh.Click += new System.EventHandler(this.btn_missingEntriesFromMachineARefresh_Click);
            // 
            // btn_missingEntriesFromMachineA
            // 
            this.btn_missingEntriesFromMachineA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_missingEntriesFromMachineA.Location = new System.Drawing.Point(94, 0);
            this.btn_missingEntriesFromMachineA.Name = "btn_missingEntriesFromMachineA";
            this.btn_missingEntriesFromMachineA.Size = new System.Drawing.Size(75, 23);
            this.btn_missingEntriesFromMachineA.TabIndex = 1;
            this.btn_missingEntriesFromMachineA.Text = "Save";
            this.btn_missingEntriesFromMachineA.UseVisualStyleBackColor = true;
            this.btn_missingEntriesFromMachineA.Click += new System.EventHandler(this.btn_missingEntriesFromMachineA_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView4.Size = new System.Drawing.Size(761, 341);
            this.dataGridView4.TabIndex = 0;
            // 
            // MatchingDifferences
            // 
            this.MatchingDifferences.Controls.Add(this.panel3);
            this.MatchingDifferences.Controls.Add(this.dataGridView5);
            this.MatchingDifferences.Location = new System.Drawing.Point(4, 22);
            this.MatchingDifferences.Name = "MatchingDifferences";
            this.MatchingDifferences.Size = new System.Drawing.Size(767, 379);
            this.MatchingDifferences.TabIndex = 4;
            this.MatchingDifferences.Text = "MatchingDifferences";
            this.MatchingDifferences.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btn_matchingDifferencesRefresh);
            this.panel3.Controls.Add(this.btn_matchingDifferences);
            this.panel3.Location = new System.Drawing.Point(567, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 23);
            this.panel3.TabIndex = 3;
            // 
            // btn_matchingDifferencesRefresh
            // 
            this.btn_matchingDifferencesRefresh.Location = new System.Drawing.Point(3, 0);
            this.btn_matchingDifferencesRefresh.Name = "btn_matchingDifferencesRefresh";
            this.btn_matchingDifferencesRefresh.Size = new System.Drawing.Size(75, 23);
            this.btn_matchingDifferencesRefresh.TabIndex = 2;
            this.btn_matchingDifferencesRefresh.Text = "Refresh";
            this.btn_matchingDifferencesRefresh.UseVisualStyleBackColor = true;
            this.btn_matchingDifferencesRefresh.Click += new System.EventHandler(this.btn_matchingDifferencesRefresh_Click);
            // 
            // btn_matchingDifferences
            // 
            this.btn_matchingDifferences.Location = new System.Drawing.Point(94, 0);
            this.btn_matchingDifferences.Name = "btn_matchingDifferences";
            this.btn_matchingDifferences.Size = new System.Drawing.Size(75, 23);
            this.btn_matchingDifferences.TabIndex = 1;
            this.btn_matchingDifferences.Text = "Save";
            this.btn_matchingDifferences.UseVisualStyleBackColor = true;
            this.btn_matchingDifferences.Click += new System.EventHandler(this.btn_matchingDifferences_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToOrderColumns = true;
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView5.Size = new System.Drawing.Size(761, 341);
            this.dataGridView5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Machine B Name";
            // 
            // textbox_registryKeyRoot
            // 
            this.textbox_registryKeyRoot.Location = new System.Drawing.Point(107, 86);
            this.textbox_registryKeyRoot.Name = "textbox_registryKeyRoot";
            this.textbox_registryKeyRoot.Size = new System.Drawing.Size(203, 20);
            this.textbox_registryKeyRoot.TabIndex = 3;
            this.textbox_registryKeyRoot.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textbox_registryKeyRoot.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registry Key Root";
            // 
            // textBox_machineBName
            // 
            this.textBox_machineBName.Location = new System.Drawing.Point(107, 60);
            this.textBox_machineBName.Name = "textBox_machineBName";
            this.textBox_machineBName.Size = new System.Drawing.Size(203, 20);
            this.textBox_machineBName.TabIndex = 2;
            this.textBox_machineBName.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox_machineBName.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox_machineAName
            // 
            this.textBox_machineAName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_machineAName.Location = new System.Drawing.Point(107, 34);
            this.textBox_machineAName.Name = "textBox_machineAName";
            this.textBox_machineAName.Size = new System.Drawing.Size(203, 20);
            this.textBox_machineAName.TabIndex = 0;
            this.textBox_machineAName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox_machineAName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_load.Location = new System.Drawing.Point(698, 82);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine A Name";
            // 
            // lbl_MachineALoading
            // 
            this.lbl_MachineALoading.AutoSize = true;
            this.lbl_MachineALoading.Location = new System.Drawing.Point(327, 40);
            this.lbl_MachineALoading.Name = "lbl_MachineALoading";
            this.lbl_MachineALoading.Size = new System.Drawing.Size(45, 13);
            this.lbl_MachineALoading.TabIndex = 8;
            this.lbl_MachineALoading.Text = "Loading";
            // 
            // lbl_MachineBLoading
            // 
            this.lbl_MachineBLoading.AutoSize = true;
            this.lbl_MachineBLoading.Location = new System.Drawing.Point(327, 63);
            this.lbl_MachineBLoading.Name = "lbl_MachineBLoading";
            this.lbl_MachineBLoading.Size = new System.Drawing.Size(45, 13);
            this.lbl_MachineBLoading.TabIndex = 9;
            this.lbl_MachineBLoading.Text = "Loading";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // combobox_registryHive
            // 
            this.combobox_registryHive.FormattingEnabled = true;
            this.combobox_registryHive.Location = new System.Drawing.Point(107, 113);
            this.combobox_registryHive.Name = "combobox_registryHive";
            this.combobox_registryHive.Size = new System.Drawing.Size(203, 21);
            this.combobox_registryHive.TabIndex = 11;
            // 
            // registryHive_lbl
            // 
            this.registryHive_lbl.AutoSize = true;
            this.registryHive_lbl.Location = new System.Drawing.Point(12, 116);
            this.registryHive_lbl.Name = "registryHive_lbl";
            this.registryHive_lbl.Size = new System.Drawing.Size(70, 13);
            this.registryHive_lbl.TabIndex = 12;
            this.registryHive_lbl.Text = "Registry Hive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 559);
            this.Controls.Add(this.registryHive_lbl);
            this.Controls.Add(this.combobox_registryHive);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_MachineBLoading);
            this.Controls.Add(this.lbl_MachineALoading);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_registryKeyRoot);
            this.Controls.Add(this.textBox_machineBName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox_machineAName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "RegCompare";
            this.tabControl1.ResumeLayout(false);
            this.s.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MachineB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.MissingEntriesFromMachineB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.MissingEntriesFromMachineA.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.MatchingDifferences.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage s;
        private System.Windows.Forms.TabPage MachineB;
        private System.Windows.Forms.TabPage MissingEntriesFromMachineB;
        private System.Windows.Forms.TabPage MissingEntriesFromMachineA;
        private System.Windows.Forms.TabPage MatchingDifferences;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_registryKeyRoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_machineBName;
        private System.Windows.Forms.TextBox textBox_machineAName;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_MachineALoading;
        private System.Windows.Forms.Label lbl_MachineBLoading;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btn_missingEntriesFromMachineA;
        private System.Windows.Forms.Button btn_missingEntriesFromMachineB;
        private System.Windows.Forms.Button btn_matchingDifferences;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_missingEntriesFromMachineBRefresh;
        private System.Windows.Forms.Button btn_missingEntriesFromMachineARefresh;
        private System.Windows.Forms.Button btn_matchingDifferencesRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combobox_registryHive;
        private System.Windows.Forms.Label registryHive_lbl;
    }
}

