namespace lab5
{
    partial class ProgressForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProgress = new lab5.dsProgress();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAddProgress = new System.Windows.Forms.Button();
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            this.iDReportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new lab5.dsProgressTableAdapters.StudentTableAdapter();
            this.progressTableAdapter = new lab5.dsProgressTableAdapters.ProgressTableAdapter();
            this.reportTableAdapter = new lab5.dsProgressTableAdapters.ReportTableAdapter();
            this.subjectTableAdapter = new lab5.dsProgressTableAdapters.SubjectTableAdapter();
            this.teacherTableAdapter = new lab5.dsProgressTableAdapters.TeacherTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 40);
            this.panel1.TabIndex = 6;
            // 
            // cbStudent
            // 
            this.cbStudent.DataSource = this.studentBindingSource;
            this.cbStudent.DisplayMember = "StName";
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(12, 12);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(121, 21);
            this.cbStudent.TabIndex = 1;
            this.cbStudent.ValueMember = "NRecordBook";
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dsProgress;
            // 
            // dsProgress
            // 
            this.dsProgress.DataSetName = "dsProgress";
            this.dsProgress.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bAddProgress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 29);
            this.panel2.TabIndex = 7;
            // 
            // bAddProgress
            // 
            this.bAddProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddProgress.AutoSize = true;
            this.bAddProgress.Location = new System.Drawing.Point(598, 3);
            this.bAddProgress.Name = "bAddProgress";
            this.bAddProgress.Size = new System.Drawing.Size(196, 23);
            this.bAddProgress.TabIndex = 0;
            this.bAddProgress.Text = "Добавить запись об успеваемости";
            this.bAddProgress.UseVisualStyleBackColor = true;
            this.bAddProgress.Click += new System.EventHandler(this.bAddProgress_Click);
            // 
            // dgvProgress
            // 
            this.dgvProgress.AllowUserToAddRows = false;
            this.dgvProgress.AllowUserToDeleteRows = false;
            this.dgvProgress.AutoGenerateColumns = false;
            this.dgvProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDReportDataGridViewTextBoxColumn,
            this.iDSubjectDataGridViewTextBoxColumn,
            this.nTermDataGridViewTextBoxColumn,
            this.pINDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn});
            this.dgvProgress.DataSource = this.progressBindingSource;
            this.dgvProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgress.Location = new System.Drawing.Point(0, 40);
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.ReadOnly = true;
            this.dgvProgress.RowHeadersVisible = false;
            this.dgvProgress.Size = new System.Drawing.Size(797, 278);
            this.dgvProgress.TabIndex = 8;
            // 
            // iDReportDataGridViewTextBoxColumn
            // 
            this.iDReportDataGridViewTextBoxColumn.DataPropertyName = "IDReport";
            this.iDReportDataGridViewTextBoxColumn.DataSource = this.reportBindingSource;
            this.iDReportDataGridViewTextBoxColumn.DisplayMember = "NameReport";
            this.iDReportDataGridViewTextBoxColumn.HeaderText = "IDReport";
            this.iDReportDataGridViewTextBoxColumn.Name = "iDReportDataGridViewTextBoxColumn";
            this.iDReportDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDReportDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDReportDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDReportDataGridViewTextBoxColumn.ValueMember = "IDReport";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.dsProgress;
            // 
            // iDSubjectDataGridViewTextBoxColumn
            // 
            this.iDSubjectDataGridViewTextBoxColumn.DataPropertyName = "IDSubject";
            this.iDSubjectDataGridViewTextBoxColumn.DataSource = this.subjectBindingSource;
            this.iDSubjectDataGridViewTextBoxColumn.DisplayMember = "NameSubject";
            this.iDSubjectDataGridViewTextBoxColumn.HeaderText = "IDSubject";
            this.iDSubjectDataGridViewTextBoxColumn.Name = "iDSubjectDataGridViewTextBoxColumn";
            this.iDSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSubjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDSubjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDSubjectDataGridViewTextBoxColumn.ValueMember = "IDSubject";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.dsProgress;
            // 
            // nTermDataGridViewTextBoxColumn
            // 
            this.nTermDataGridViewTextBoxColumn.DataPropertyName = "NTerm";
            this.nTermDataGridViewTextBoxColumn.HeaderText = "NTerm";
            this.nTermDataGridViewTextBoxColumn.Name = "nTermDataGridViewTextBoxColumn";
            this.nTermDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pINDataGridViewTextBoxColumn
            // 
            this.pINDataGridViewTextBoxColumn.DataPropertyName = "PIN";
            this.pINDataGridViewTextBoxColumn.DataSource = this.teacherBindingSource;
            this.pINDataGridViewTextBoxColumn.DisplayMember = "TeachName";
            this.pINDataGridViewTextBoxColumn.HeaderText = "PIN";
            this.pINDataGridViewTextBoxColumn.Name = "pINDataGridViewTextBoxColumn";
            this.pINDataGridViewTextBoxColumn.ReadOnly = true;
            this.pINDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pINDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pINDataGridViewTextBoxColumn.ValueMember = "PIN";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dsProgress;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progressBindingSource
            // 
            this.progressBindingSource.DataMember = "Progress";
            this.progressBindingSource.DataSource = this.dsProgress;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // progressTableAdapter
            // 
            this.progressTableAdapter.ClearBeforeFill = true;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 347);
            this.Controls.Add(this.dgvProgress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProgressForm";
            this.Text = "Успеваемость студента";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAddProgress;
        private System.Windows.Forms.DataGridView dgvProgress;
        private dsProgress dsProgress;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dsProgressTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource progressBindingSource;
        private dsProgressTableAdapters.ProgressTableAdapter progressTableAdapter;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private dsProgressTableAdapters.ReportTableAdapter reportTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private dsProgressTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private dsProgressTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDReportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
    }
}