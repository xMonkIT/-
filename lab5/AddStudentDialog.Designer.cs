namespace lab5
{
    partial class AddStudentDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNRecordBook = new System.Windows.Forms.TextBox();
            this.dtpDataPasport = new System.Windows.Forms.DateTimePicker();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.sGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProgress = new lab5.dsProgress();
            this.bOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbNameDeptPasport = new System.Windows.Forms.TextBox();
            this.tbNPasport = new System.Windows.Forms.TextBox();
            this.tbSPasport = new System.Windows.Forms.TextBox();
            this.tbStName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.sGroupTableAdapter = new lab5.dsProgressTableAdapters.SGroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер зачетки:";
            // 
            // tbNRecordBook
            // 
            this.tbNRecordBook.Location = new System.Drawing.Point(3, 6);
            this.tbNRecordBook.Name = "tbNRecordBook";
            this.tbNRecordBook.Size = new System.Drawing.Size(140, 20);
            this.tbNRecordBook.TabIndex = 1;
            // 
            // dtpDataPasport
            // 
            this.dtpDataPasport.Location = new System.Drawing.Point(3, 110);
            this.dtpDataPasport.Name = "dtpDataPasport";
            this.dtpDataPasport.Size = new System.Drawing.Size(140, 20);
            this.dtpDataPasport.TabIndex = 2;
            // 
            // cbGroup
            // 
            this.cbGroup.DataSource = this.sGroupBindingSource;
            this.cbGroup.DisplayMember = "NameGroup";
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(3, 188);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(140, 21);
            this.cbGroup.TabIndex = 3;
            this.cbGroup.ValueMember = "IDGroup";
            // 
            // sGroupBindingSource
            // 
            this.sGroupBindingSource.DataMember = "SGroup";
            this.sGroupBindingSource.DataSource = this.dsProgress;
            // 
            // dsProgress
            // 
            this.dsProgress.DataSetName = "dsProgress";
            this.dsProgress.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(234, 3);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Серия паспорта:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ИНН:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Место выдачи паспорта:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Фамилия и инициалы:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Номер паспорта:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Дата выдачи паспорта:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 221);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbINN);
            this.panel2.Controls.Add(this.tbNameDeptPasport);
            this.panel2.Controls.Add(this.tbNPasport);
            this.panel2.Controls.Add(this.tbSPasport);
            this.panel2.Controls.Add(this.tbStName);
            this.panel2.Controls.Add(this.cbGroup);
            this.panel2.Controls.Add(this.dtpDataPasport);
            this.panel2.Controls.Add(this.tbNRecordBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(159, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 215);
            this.panel2.TabIndex = 1;
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(3, 162);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(140, 20);
            this.tbINN.TabIndex = 8;
            // 
            // tbNameDeptPasport
            // 
            this.tbNameDeptPasport.Location = new System.Drawing.Point(3, 136);
            this.tbNameDeptPasport.Name = "tbNameDeptPasport";
            this.tbNameDeptPasport.Size = new System.Drawing.Size(140, 20);
            this.tbNameDeptPasport.TabIndex = 7;
            // 
            // tbNPasport
            // 
            this.tbNPasport.Location = new System.Drawing.Point(3, 84);
            this.tbNPasport.Name = "tbNPasport";
            this.tbNPasport.Size = new System.Drawing.Size(140, 20);
            this.tbNPasport.TabIndex = 6;
            // 
            // tbSPasport
            // 
            this.tbSPasport.Location = new System.Drawing.Point(3, 58);
            this.tbSPasport.Name = "tbSPasport";
            this.tbSPasport.Size = new System.Drawing.Size(140, 20);
            this.tbSPasport.TabIndex = 5;
            // 
            // tbStName
            // 
            this.tbStName.Location = new System.Drawing.Point(3, 32);
            this.tbStName.Name = "tbStName";
            this.tbStName.Size = new System.Drawing.Size(140, 20);
            this.tbStName.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 215);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 267);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bCancel);
            this.panel3.Controls.Add(this.bOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 34);
            this.panel3.TabIndex = 15;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(153, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // sGroupTableAdapter
            // 
            this.sGroupTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentDialog
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(318, 267);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddStudentDialog";
            this.Text = "Добавление нового студента";
            this.Load += new System.EventHandler(this.AddStudentDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private dsProgress dsProgress;
        private System.Windows.Forms.BindingSource sGroupBindingSource;
        private dsProgressTableAdapters.SGroupTableAdapter sGroupTableAdapter;
        private System.Windows.Forms.Button bCancel;
        internal System.Windows.Forms.TextBox tbNRecordBook;
        internal System.Windows.Forms.TextBox tbStName;
        internal System.Windows.Forms.TextBox tbSPasport;
        internal System.Windows.Forms.TextBox tbNPasport;
        internal System.Windows.Forms.DateTimePicker dtpDataPasport;
        internal System.Windows.Forms.ComboBox cbGroup;
        internal System.Windows.Forms.TextBox tbINN;
        internal System.Windows.Forms.TextBox tbNameDeptPasport;
    }
}