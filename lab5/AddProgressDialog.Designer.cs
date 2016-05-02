namespace lab5
{
    partial class AddProgressDialog
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudNTerm = new System.Windows.Forms.NumericUpDown();
            this.nudMark = new System.Windows.Forms.NumericUpDown();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProgress = new lab5.dsProgress();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectTableAdapter = new lab5.dsProgressTableAdapters.SubjectTableAdapter();
            this.reportTableAdapter = new lab5.dsProgressTableAdapters.ReportTableAdapter();
            this.studentTableAdapter = new lab5.dsProgressTableAdapters.StudentTableAdapter();
            this.teacherTableAdapter = new lab5.dsProgressTableAdapters.TeacherTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 224);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bCancel);
            this.panel3.Controls.Add(this.bOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 34);
            this.panel3.TabIndex = 15;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(146, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(227, 3);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 178);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudNTerm);
            this.panel2.Controls.Add(this.nudMark);
            this.panel2.Controls.Add(this.cbTeacher);
            this.panel2.Controls.Add(this.cbReport);
            this.panel2.Controls.Add(this.cbSubject);
            this.panel2.Controls.Add(this.cbStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(155, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 172);
            this.panel2.TabIndex = 1;
            // 
            // nudNTerm
            // 
            this.nudNTerm.Location = new System.Drawing.Point(3, 33);
            this.nudNTerm.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNTerm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNTerm.Name = "nudNTerm";
            this.nudNTerm.Size = new System.Drawing.Size(140, 20);
            this.nudNTerm.TabIndex = 9;
            this.nudNTerm.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nudMark
            // 
            this.nudMark.Location = new System.Drawing.Point(3, 140);
            this.nudMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMark.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMark.Name = "nudMark";
            this.nudMark.Size = new System.Drawing.Size(140, 20);
            this.nudMark.TabIndex = 8;
            this.nudMark.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cbTeacher
            // 
            this.cbTeacher.DataSource = this.teacherBindingSource;
            this.cbTeacher.DisplayMember = "TeachName";
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(3, 113);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(140, 21);
            this.cbTeacher.TabIndex = 7;
            this.cbTeacher.ValueMember = "PIN";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dsProgress;
            // 
            // dsProgress
            // 
            this.dsProgress.DataSetName = "dsProgress";
            this.dsProgress.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbReport
            // 
            this.cbReport.DataSource = this.reportBindingSource;
            this.cbReport.DisplayMember = "NameReport";
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(3, 59);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(140, 21);
            this.cbReport.TabIndex = 5;
            this.cbReport.ValueMember = "IDReport";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.dsProgress;
            // 
            // cbSubject
            // 
            this.cbSubject.DataSource = this.subjectBindingSource;
            this.cbSubject.DisplayMember = "NameSubject";
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(3, 6);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(140, 21);
            this.cbSubject.TabIndex = 4;
            this.cbSubject.ValueMember = "IDSubject";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.dsProgress;
            // 
            // cbStudent
            // 
            this.cbStudent.DataSource = this.studentBindingSource;
            this.cbStudent.DisplayMember = "StName";
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(3, 86);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(140, 21);
            this.cbStudent.TabIndex = 3;
            this.cbStudent.ValueMember = "NRecordBook";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dsProgress;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 172);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предмет:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Оценка:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Преподаватель:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Номер семестра:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Студент:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип отчета:";
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // AddProgressDialog
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(311, 224);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddProgressDialog";
            this.Text = "Добавление записи об успеваемости";
            this.Load += new System.EventHandler(this.AddProgressDialog_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.NumericUpDown nudMark;
        internal System.Windows.Forms.ComboBox cbTeacher;
        internal System.Windows.Forms.ComboBox cbReport;
        internal System.Windows.Forms.ComboBox cbSubject;
        internal System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown nudNTerm;
        private dsProgress dsProgress;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private dsProgressTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private dsProgressTableAdapters.ReportTableAdapter reportTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dsProgressTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private dsProgressTableAdapters.TeacherTableAdapter teacherTableAdapter;
    }
}