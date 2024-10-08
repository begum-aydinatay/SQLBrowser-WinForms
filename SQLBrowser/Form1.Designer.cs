﻿namespace SQLBrowser
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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtServerName = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            txtUsername = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            txtPassword = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnConnect = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            toolStripLabel4 = new ToolStripLabel();
            cmbDatabases = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel5 = new ToolStripLabel();
            cmbTables = new ToolStripComboBox();
            btnRun = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            clbColumns = new CheckedListBox();
            splitContainer2 = new SplitContainer();
            txtQuery = new TextBox();
            dgvResults = new DataGridView();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtServerName, toolStripLabel2, txtUsername, toolStripLabel3, txtPassword, toolStripSeparator1, btnConnect });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(820, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(97, 24);
            toolStripLabel1.Text = "Server Name:";
            // 
            // txtServerName
            // 
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(150, 27);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(78, 24);
            toolStripLabel2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 27);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(73, 24);
            toolStripLabel3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 27);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnConnect
            // 
            btnConnect.Image = Properties.Resources.connect_icon;
            btnConnect.ImageTransparentColor = Color.Magenta;
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(87, 24);
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel4, cmbDatabases, toolStripSeparator2, toolStripLabel5, cmbTables, btnRun });
            toolStrip2.Location = new Point(0, 27);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(820, 28);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(81, 25);
            toolStripLabel4.Text = "Databases:";
            // 
            // cmbDatabases
            // 
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(150, 28);
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(53, 25);
            toolStripLabel5.Text = "Tables:";
            // 
            // cmbTables
            // 
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(150, 28);
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // btnRun
            // 
            btnRun.Image = Properties.Resources.run_icon;
            btnRun.ImageTransparentColor = Color.Magenta;
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(58, 25);
            btnRun.Text = "Run";
            btnRun.Click += btnRun_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(clbColumns);
            splitContainer1.Panel1.Padding = new Padding(8);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Padding = new Padding(8);
            splitContainer1.Size = new Size(820, 395);
            splitContainer1.SplitterDistance = 273;
            splitContainer1.TabIndex = 2;
            // 
            // clbColumns
            // 
            clbColumns.CheckOnClick = true;
            clbColumns.Dock = DockStyle.Fill;
            clbColumns.FormattingEnabled = true;
            clbColumns.Location = new Point(8, 8);
            clbColumns.Name = "clbColumns";
            clbColumns.Size = new Size(257, 379);
            clbColumns.TabIndex = 0;
            clbColumns.SelectedIndexChanged += clbColumns_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(8, 8);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtQuery);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvResults);
            splitContainer2.Size = new Size(527, 379);
            splitContainer2.SplitterDistance = 134;
            splitContainer2.TabIndex = 0;
            // 
            // txtQuery
            // 
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuery.Location = new Point(0, 0);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.ScrollBars = ScrollBars.Vertical;
            txtQuery.Size = new Size(527, 134);
            txtQuery.TabIndex = 0;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(0, 0);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(527, 241);
            dgvResults.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "SQL Browser";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtServerName;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtUsername;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox txtPassword;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnConnect;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel4;
        private ToolStripComboBox cmbDatabases;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel5;
        private ToolStripComboBox cmbTables;
        private ToolStripButton btnRun;
        private SplitContainer splitContainer1;
        private CheckedListBox clbColumns;
        private SplitContainer splitContainer2;
        private TextBox txtQuery;
        private DataGridView dgvResults;
    }
}
