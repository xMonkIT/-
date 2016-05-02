using System;
using System.Data;
using System.Windows.Forms;

namespace lab5
{
    public partial class ProgressForm : Form
    {
        private readonly string _nRecordBook;

        public ProgressForm(string nRecordBook)
        {
            InitializeComponent();
            _nRecordBook = nRecordBook;
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            teacherTableAdapter.Fill(dsProgress.Teacher);
            subjectTableAdapter.Fill(dsProgress.Subject);
            reportTableAdapter.Fill(dsProgress.Report);
            progressTableAdapter.Fill(dsProgress.Progress);
            studentTableAdapter.Fill(dsProgress.Student);

            cbStudent.SelectedValue = _nRecordBook;

            if (cbStudent.SelectedIndex != 1)
                cbStudent_SelectedIndexChanged(cbStudent, new EventArgs());
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedValue != null)
                progressBindingSource.Filter = $"NRecordBook = {cbStudent.SelectedValue}";
        }

        private void bAddProgress_Click(object sender, EventArgs e)
        {
            var dlg = new AddProgressDialog();

            if (dlg.ShowDialog() != DialogResult.OK) return;

            dsProgress.Progress.AddProgressRow(
                (dlg.cbReport.SelectedItem as DataRowView)?.Row as dsProgress.ReportRow,
                (dlg.cbSubject.SelectedItem as DataRowView)?.Row as dsProgress.SubjectRow,
                (dlg.cbStudent.SelectedItem as DataRowView)?.Row as dsProgress.StudentRow,
                dlg.nudNTerm.Value,
                (dlg.cbTeacher.SelectedItem as DataRowView)?.Row as dsProgress.TeacherRow,
                (short) dlg.nudMark.Value);

            progressTableAdapter
                .Update(dsProgress.Tables["Progress"] as dsProgress.ProgressDataTable);
        }
    }
}
