namespace System_Notification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgEmpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIssuedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgValidUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BttnSave = new System.Windows.Forms.Button();
            this.BttnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IssuedOnBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValidUntilBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpNumberBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CertNoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ShowToolStripMenuItem.Text = "Show";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Settings";
            this.notifyIcon1.Visible = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEmpNumber,
            this.dgEmpID,
            this.dgFirstName,
            this.dgMiddleName,
            this.dgLastName,
            this.dgCertificateNumber,
            this.dgIssuedOn,
            this.dgValidUntil});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(17, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(751, 406);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // dgEmpNumber
            // 
            this.dgEmpNumber.DataPropertyName = "EmpNumber";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            this.dgEmpNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEmpNumber.HeaderText = "EmpNumber";
            this.dgEmpNumber.Name = "dgEmpNumber";
            this.dgEmpNumber.ReadOnly = true;
            // 
            // dgEmpID
            // 
            this.dgEmpID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEmpID.DataPropertyName = "EmpID";
            this.dgEmpID.HeaderText = "Employee ID";
            this.dgEmpID.Name = "dgEmpID";
            this.dgEmpID.ReadOnly = true;
            this.dgEmpID.Visible = false;
            // 
            // dgFirstName
            // 
            this.dgFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgFirstName.DataPropertyName = "FirstName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgFirstName.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgFirstName.HeaderText = "First Name";
            this.dgFirstName.Name = "dgFirstName";
            this.dgFirstName.ReadOnly = true;
            // 
            // dgMiddleName
            // 
            this.dgMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgMiddleName.DataPropertyName = "MiddleName";
            this.dgMiddleName.HeaderText = "Middle Name";
            this.dgMiddleName.Name = "dgMiddleName";
            this.dgMiddleName.ReadOnly = true;
            // 
            // dgLastName
            // 
            this.dgLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgLastName.DataPropertyName = "LastName";
            this.dgLastName.HeaderText = "Last Name";
            this.dgLastName.Name = "dgLastName";
            this.dgLastName.ReadOnly = true;
            // 
            // dgCertificateNumber
            // 
            this.dgCertificateNumber.DataPropertyName = "CertificateNumber";
            this.dgCertificateNumber.HeaderText = "Certificate Number";
            this.dgCertificateNumber.Name = "dgCertificateNumber";
            this.dgCertificateNumber.ReadOnly = true;
            // 
            // dgIssuedOn
            // 
            this.dgIssuedOn.DataPropertyName = "IssuedOn";
            this.dgIssuedOn.HeaderText = "Issued On";
            this.dgIssuedOn.Name = "dgIssuedOn";
            this.dgIssuedOn.ReadOnly = true;
            // 
            // dgValidUntil
            // 
            this.dgValidUntil.DataPropertyName = "ValidUntil";
            this.dgValidUntil.HeaderText = "Valid Until";
            this.dgValidUntil.Name = "dgValidUntil";
            this.dgValidUntil.ReadOnly = true;
            // 
            // BttnSave
            // 
            this.BttnSave.BackColor = System.Drawing.Color.Transparent;
            this.BttnSave.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BttnSave.Location = new System.Drawing.Point(785, 437);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(87, 32);
            this.BttnSave.TabIndex = 2;
            this.BttnSave.Text = "Save";
            this.BttnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BttnSave.UseVisualStyleBackColor = false;
            this.BttnSave.Click += new System.EventHandler(this.BttnSave_Click);
            // 
            // BttnCancel
            // 
            this.BttnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BttnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BttnCancel.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCancel.Location = new System.Drawing.Point(891, 437);
            this.BttnCancel.Name = "BttnCancel";
            this.BttnCancel.Size = new System.Drawing.Size(87, 32);
            this.BttnCancel.TabIndex = 3;
            this.BttnCancel.Text = "Cancel";
            this.BttnCancel.UseVisualStyleBackColor = false;
            this.BttnCancel.Click += new System.EventHandler(this.BttnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(-1, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 27);
            this.panel2.TabIndex = 5;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(793, 189);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(177, 20);
            this.FirstNameBox.TabIndex = 6;
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(793, 233);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(177, 20);
            this.MiddleNameBox.TabIndex = 7;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(792, 275);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(177, 20);
            this.LastNameBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(794, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(794, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(794, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // IssuedOnBox
            // 
            this.IssuedOnBox.Location = new System.Drawing.Point(792, 359);
            this.IssuedOnBox.Name = "IssuedOnBox";
            this.IssuedOnBox.Size = new System.Drawing.Size(177, 20);
            this.IssuedOnBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(794, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Issued On :";
            // 
            // ValidUntilBox
            // 
            this.ValidUntilBox.Location = new System.Drawing.Point(792, 403);
            this.ValidUntilBox.Name = "ValidUntilBox";
            this.ValidUntilBox.Size = new System.Drawing.Size(177, 20);
            this.ValidUntilBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(794, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valid Until :";
            // 
            // EmpNumberBox
            // 
            this.EmpNumberBox.Location = new System.Drawing.Point(792, 146);
            this.EmpNumberBox.Name = "EmpNumberBox";
            this.EmpNumberBox.Size = new System.Drawing.Size(177, 20);
            this.EmpNumberBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(794, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Employee Number";
            // 
            // CertNoBox
            // 
            this.CertNoBox.Location = new System.Drawing.Point(792, 317);
            this.CertNoBox.Name = "CertNoBox";
            this.CertNoBox.Size = new System.Drawing.Size(177, 20);
            this.CertNoBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(794, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Certificate No.";
            // 
            // BttnDelete
            // 
            this.BttnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BttnDelete.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Location = new System.Drawing.Point(838, 485);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(87, 32);
            this.BttnDelete.TabIndex = 20;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = false;
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 93);
            this.panel4.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "AND ENGINEERING SERVICES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(103, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "FTPONTILLO BUILDERS\r\n";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::System_Notification.Properties.Resources.FTP_Logo_With_Name___transparent_bg;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(19, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(79, 71);
            this.panel5.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Generate Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GenerateData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1005, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BttnDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CertNoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpNumberBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ValidUntilBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IssuedOnBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BttnCancel);
            this.Controls.Add(this.BttnSave);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP System";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttnSave;
        private System.Windows.Forms.Button BttnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IssuedOnBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ValidUntilBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmpNumberBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CertNoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCertificateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIssuedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgValidUntil;
        private System.Windows.Forms.Button button1;
    }
}

