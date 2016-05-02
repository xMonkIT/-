namespace lab5
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProgress = new lab5.dsProgress();
            this.studentTableAdapter = new lab5.dsProgressTableAdapters.StudentTableAdapter();
            this.sGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGroupTableAdapter = new lab5.dsProgressTableAdapters.SGroupTableAdapter();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAddStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bAddUPlan = new System.Windows.Forms.Button();
            this.dgvUPlans = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uPlanTableAdapter = new lab5.dsProgressTableAdapters.UPlanTableAdapter();
            this.subjectTableAdapter = new lab5.dsProgressTableAdapters.SubjectTableAdapter();
            this.workTableAdapter = new lab5.dsProgressTableAdapters.WorkTableAdapter();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new lab5.dsProgressTableAdapters.TeacherTableAdapter();
            this.iDSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNRecordBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDeptPasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGroupBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // sGroupBindingSource
            // 
            this.sGroupBindingSource.DataMember = "SGroup";
            this.sGroupBindingSource.DataSource = this.dsProgress;
            // 
            // sGroupTableAdapter
            // 
            this.sGroupTableAdapter.ClearBeforeFill = true;
            // 
            // cbGroup
            // 
            this.cbGroup.DataSource = this.sGroupBindingSource;
            this.cbGroup.DisplayMember = "NameGroup";
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(12, 12);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(121, 21);
            this.cbGroup.TabIndex = 1;
            this.cbGroup.ValueMember = "IDGroup";
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 40);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 335);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dgvStudents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bAddStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 29);
            this.panel2.TabIndex = 4;
            // 
            // bAddStudent
            // 
            this.bAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddStudent.AutoSize = true;
            this.bAddStudent.Location = new System.Drawing.Point(638, 3);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(115, 23);
            this.bAddStudent.TabIndex = 0;
            this.bAddStudent.Text = "Добавить студента";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcNRecordBook,
            this.stNameDataGridViewTextBoxColumn,
            this.sPasportDataGridViewTextBoxColumn,
            this.nPasportDataGridViewTextBoxColumn,
            this.dataPasportDataGridViewTextBoxColumn,
            this.nameDeptPasportDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentBindingSource;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.Size = new System.Drawing.Size(756, 303);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dgvUPlans);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учебный план";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bAddUPlan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 29);
            this.panel3.TabIndex = 6;
            // 
            // bAddUPlan
            // 
            this.bAddUPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddUPlan.AutoSize = true;
            this.bAddUPlan.Location = new System.Drawing.Point(638, 3);
            this.bAddUPlan.Name = "bAddUPlan";
            this.bAddUPlan.Size = new System.Drawing.Size(115, 23);
            this.bAddUPlan.TabIndex = 0;
            this.bAddUPlan.Text = "Добавить запись";
            this.bAddUPlan.UseVisualStyleBackColor = true;
            this.bAddUPlan.Click += new System.EventHandler(this.bAddUPlan_Click);
            // 
            // dgvUPlans
            // 
            this.dgvUPlans.AllowUserToAddRows = false;
            this.dgvUPlans.AllowUserToDeleteRows = false;
            this.dgvUPlans.AutoGenerateColumns = false;
            this.dgvUPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSubjectDataGridViewTextBoxColumn,
            this.nTermDataGridViewTextBoxColumn,
            this.iDWorkDataGridViewTextBoxColumn,
            this.pINDataGridViewTextBoxColumn,
            this.clockDataGridViewTextBoxColumn});
            this.dgvUPlans.DataSource = this.uPlanBindingSource;
            this.dgvUPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUPlans.Location = new System.Drawing.Point(3, 3);
            this.dgvUPlans.Name = "dgvUPlans";
            this.dgvUPlans.ReadOnly = true;
            this.dgvUPlans.RowHeadersVisible = false;
            this.dgvUPlans.Size = new System.Drawing.Size(756, 303);
            this.dgvUPlans.TabIndex = 5;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.dsProgress;
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataMember = "Work";
            this.workBindingSource.DataSource = this.dsProgress;
            // 
            // uPlanBindingSource
            // 
            this.uPlanBindingSource.DataMember = "UPlan";
            this.uPlanBindingSource.DataSource = this.dsProgress;
            // 
            // uPlanTableAdapter
            // 
            this.uPlanTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // workTableAdapter
            // 
            this.workTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dsProgress;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
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
            // nTermDataGridViewTextBoxColumn
            // 
            this.nTermDataGridViewTextBoxColumn.DataPropertyName = "NTerm";
            this.nTermDataGridViewTextBoxColumn.HeaderText = "NTerm";
            this.nTermDataGridViewTextBoxColumn.Name = "nTermDataGridViewTextBoxColumn";
            this.nTermDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDWorkDataGridViewTextBoxColumn
            // 
            this.iDWorkDataGridViewTextBoxColumn.DataPropertyName = "IDWork";
            this.iDWorkDataGridViewTextBoxColumn.DataSource = this.workBindingSource;
            this.iDWorkDataGridViewTextBoxColumn.DisplayMember = "NameWork";
            this.iDWorkDataGridViewTextBoxColumn.HeaderText = "IDWork";
            this.iDWorkDataGridViewTextBoxColumn.Name = "iDWorkDataGridViewTextBoxColumn";
            this.iDWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDWorkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDWorkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDWorkDataGridViewTextBoxColumn.ValueMember = "IDWork";
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
            // clockDataGridViewTextBoxColumn
            // 
            this.clockDataGridViewTextBoxColumn.DataPropertyName = "Clock";
            this.clockDataGridViewTextBoxColumn.HeaderText = "Clock";
            this.clockDataGridViewTextBoxColumn.Name = "clockDataGridViewTextBoxColumn";
            this.clockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvtbcNRecordBook
            // 
            this.dgvtbcNRecordBook.DataPropertyName = "NRecordBook";
            this.dgvtbcNRecordBook.HeaderText = "NRecordBook";
            this.dgvtbcNRecordBook.Name = "dgvtbcNRecordBook";
            this.dgvtbcNRecordBook.ReadOnly = true;
            // 
            // stNameDataGridViewTextBoxColumn
            // 
            this.stNameDataGridViewTextBoxColumn.DataPropertyName = "StName";
            this.stNameDataGridViewTextBoxColumn.HeaderText = "StName";
            this.stNameDataGridViewTextBoxColumn.Name = "stNameDataGridViewTextBoxColumn";
            this.stNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPasportDataGridViewTextBoxColumn
            // 
            this.sPasportDataGridViewTextBoxColumn.DataPropertyName = "SPasport";
            this.sPasportDataGridViewTextBoxColumn.HeaderText = "SPasport";
            this.sPasportDataGridViewTextBoxColumn.Name = "sPasportDataGridViewTextBoxColumn";
            this.sPasportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nPasportDataGridViewTextBoxColumn
            // 
            this.nPasportDataGridViewTextBoxColumn.DataPropertyName = "NPasport";
            this.nPasportDataGridViewTextBoxColumn.HeaderText = "NPasport";
            this.nPasportDataGridViewTextBoxColumn.Name = "nPasportDataGridViewTextBoxColumn";
            this.nPasportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPasportDataGridViewTextBoxColumn
            // 
            this.dataPasportDataGridViewTextBoxColumn.DataPropertyName = "DataPasport";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataPasportDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataPasportDataGridViewTextBoxColumn.HeaderText = "DataPasport";
            this.dataPasportDataGridViewTextBoxColumn.Name = "dataPasportDataGridViewTextBoxColumn";
            this.dataPasportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDeptPasportDataGridViewTextBoxColumn
            // 
            this.nameDeptPasportDataGridViewTextBoxColumn.DataPropertyName = "NameDeptPasport";
            this.nameDeptPasportDataGridViewTextBoxColumn.HeaderText = "NameDeptPasport";
            this.nameDeptPasportDataGridViewTextBoxColumn.Name = "nameDeptPasportDataGridViewTextBoxColumn";
            this.nameDeptPasportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 375);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGroupBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsProgress dsProgress;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dsProgressTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource sGroupBindingSource;
        private dsProgressTableAdapters.SGroupTableAdapter sGroupTableAdapter;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bAddUPlan;
        private System.Windows.Forms.DataGridView dgvUPlans;
        private System.Windows.Forms.BindingSource uPlanBindingSource;
        private dsProgressTableAdapters.UPlanTableAdapter uPlanTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private dsProgressTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource workBindingSource;
        private dsProgressTableAdapters.WorkTableAdapter workTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private dsProgressTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNRecordBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDeptPasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
    }
}

