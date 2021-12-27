
namespace DBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.comboBoxColumnsTypes = new System.Windows.Forms.ComboBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tablesControl = new System.Windows.Forms.TabControl();
			this.openDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialogChooseFilePath = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogSaveDatabase = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.columnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
			this.rowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.columnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.proectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
			this.createToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxColumnsTypes
			// 
			this.comboBoxColumnsTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxColumnsTypes.FormattingEnabled = true;
			this.comboBoxColumnsTypes.Items.AddRange(new object[] {
            "Integer",
            "String",
            "Char",
            "Real",
            "Time",
            "TimeInvl"});
			this.comboBoxColumnsTypes.Location = new System.Drawing.Point(1141, 31);
			this.comboBoxColumnsTypes.Name = "comboBoxColumnsTypes";
			this.comboBoxColumnsTypes.Size = new System.Drawing.Size(151, 28);
			this.comboBoxColumnsTypes.TabIndex = 12;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(16, 80);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(1280, 609);
			this.dataGridView.TabIndex = 18;
			this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
			this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
			// 
			// tablesControl
			// 
			this.tablesControl.Location = new System.Drawing.Point(16, 31);
			this.tablesControl.Name = "tablesControl";
			this.tablesControl.SelectedIndex = 0;
			this.tablesControl.Size = new System.Drawing.Size(1280, 43);
			this.tablesControl.TabIndex = 19;
			this.tablesControl.SelectedIndexChanged += new System.EventHandler(this.tablesControl_SelectedIndexChanged);
			// 
			// openDatabaseDialog
			// 
			this.openDatabaseDialog.FileName = "openFileDialog1";
			this.openDatabaseDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDatabaseDialog_FileOk);
			// 
			// openFileDialogChooseFilePath
			// 
			this.openFileDialogChooseFilePath.FileName = "openFileDialog1";
			this.openFileDialogChooseFilePath.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogChooseFilePath_FileOk);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.proectionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1349, 28);
			this.menuStrip1.TabIndex = 21;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dataBaseToolStripMenuItem
			// 
			this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
			this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
			this.dataBaseToolStripMenuItem.Text = "DataBase";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
			this.createToolStripMenuItem.Text = "Create";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
			this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
			this.openToolStripMenuItem.Text = "Open...";
			// 
			// toolStripTextBox2
			// 
			this.toolStripTextBox2.Name = "toolStripTextBox2";
			this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
			this.toolStripTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyUp);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// tableToolStripMenuItem
			// 
			this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnToolStripMenuItem,
            this.rowToolStripMenuItem,
            this.columnToolStripMenuItem1,
            this.rowToolStripMenuItem1});
			this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
			this.tableToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.tableToolStripMenuItem.Text = "Table";
			// 
			// columnToolStripMenuItem
			// 
			this.columnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
			this.columnToolStripMenuItem.Name = "columnToolStripMenuItem";
			this.columnToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.columnToolStripMenuItem.Text = "Create";
			// 
			// toolStripTextBox3
			// 
			this.toolStripTextBox3.Name = "toolStripTextBox3";
			this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
			this.toolStripTextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox3_KeyUp);
			// 
			// rowToolStripMenuItem
			// 
			this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
			this.rowToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.rowToolStripMenuItem.Text = "Delete";
			this.rowToolStripMenuItem.Click += new System.EventHandler(this.rowToolStripMenuItem_Click);
			// 
			// columnToolStripMenuItem1
			// 
			this.columnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.deleteToolStripMenuItem});
			this.columnToolStripMenuItem1.Name = "columnToolStripMenuItem1";
			this.columnToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
			this.columnToolStripMenuItem1.Text = "Column";
			// 
			// createToolStripMenuItem1
			// 
			this.createToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.toolStripComboBox1});
			this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
			this.createToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
			this.createToolStripMenuItem1.Text = "Add";
			// 
			// toolStripTextBox4
			// 
			this.toolStripTextBox4.Name = "toolStripTextBox4";
			this.toolStripTextBox4.Size = new System.Drawing.Size(100, 27);
			this.toolStripTextBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox4_KeyUp);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox1.Items.AddRange(new object[] {
            "Integer",
            "String",
            "Char",
            "Real",
            "Time",
            "TimeInvl"});
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// rowToolStripMenuItem1
			// 
			this.rowToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.deleteToolStripMenuItem1});
			this.rowToolStripMenuItem1.Name = "rowToolStripMenuItem1";
			this.rowToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
			this.rowToolStripMenuItem1.Text = "Row";
			// 
			// createToolStripMenuItem2
			// 
			this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
			this.createToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
			this.createToolStripMenuItem2.Text = "Add";
			this.createToolStripMenuItem2.Click += new System.EventHandler(this.createToolStripMenuItem2_Click);
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
			this.deleteToolStripMenuItem1.Text = "Delete";
			this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
			// 
			// proectionToolStripMenuItem
			// 
			this.proectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox5,
            this.createToolStripMenuItem3});
			this.proectionToolStripMenuItem.Name = "proectionToolStripMenuItem";
			this.proectionToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.proectionToolStripMenuItem.Text = "Projection";
			// 
			// toolStripTextBox5
			// 
			this.toolStripTextBox5.Name = "toolStripTextBox5";
			this.toolStripTextBox5.Size = new System.Drawing.Size(100, 27);
			this.toolStripTextBox5.ToolTipText = "Column name";
			this.toolStripTextBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox5_KeyUp);
			// 
			// createToolStripMenuItem3
			// 
			this.createToolStripMenuItem3.Name = "createToolStripMenuItem3";
			this.createToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
			this.createToolStripMenuItem3.Text = "Create";
			this.createToolStripMenuItem3.Click += new System.EventHandler(this.createToolStripMenuItem3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1349, 749);
			this.Controls.Add(this.tablesControl);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.comboBoxColumnsTypes);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColumnsTypes;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tablesControl;
        private System.Windows.Forms.OpenFileDialog openDatabaseDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogChooseFilePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveDatabase;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem columnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem columnToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripMenuItem proectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem3;
	}
}

