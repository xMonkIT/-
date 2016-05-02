using System;
using System.Data;
using System.Windows.Forms;

namespace lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            teacherTableAdapter.Fill(dsProgress.Teacher);
            workTableAdapter.Fill(dsProgress.Work);
            subjectTableAdapter.Fill(dsProgress.Subject);
            uPlanTableAdapter.Fill(dsProgress.UPlan);
            sGroupTableAdapter.Fill(dsProgress.SGroup);
            studentTableAdapter.Fill(dsProgress.Student);
            cbGroup_SelectedIndexChanged(cbGroup, new EventArgs());
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroup.SelectedValue != null)
                studentBindingSource.Filter =
                    uPlanBindingSource.Filter = $"IDGroup = {cbGroup.SelectedValue}";
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            var dlg = new AddStudentDialog();

            if (dlg.ShowDialog() != DialogResult.OK) return;

            dsProgress.Student.AddStudentRow(
                dlg.tbNRecordBook.Text,
                dlg.tbStName.Text,
                dlg.tbSPasport.Text,
                dlg.tbNPasport.Text,
                dlg.dtpDataPasport.Value,
                dlg.tbNameDeptPasport.Text,
                dlg.tbINN.Text,
                (dlg.cbGroup.SelectedItem as DataRowView)?.Row as dsProgress.SGroupRow);

            studentTableAdapter.Update(dsProgress.Tables["Student"] as dsProgress.StudentDataTable);
        }

        private void bAddUPlan_Click(object sender, EventArgs e)
        {
            var dlg = new AddUPlanDialog();

            if (dlg.ShowDialog() != DialogResult.OK) return;

            dsProgress.UPlan.AddUPlanRow(
                (dlg.cbSubject.SelectedItem as DataRowView)?.Row as dsProgress.SubjectRow,
                dlg.tbNTerm.Text,
                (dlg.cbWork.SelectedItem as DataRowView)?.Row as dsProgress.WorkRow,
                (dlg.cbGroup.SelectedItem as DataRowView)?.Row as dsProgress.SGroupRow,
                (dlg.cbTeacher.SelectedItem as DataRowView)?.Row as dsProgress.TeacherRow,
                dlg.nudClock.Value);

            uPlanTableAdapter.Update(dsProgress.Tables["UPlan"] as dsProgress.UPlanDataTable);
        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
            new ProgressForm(dgvStudents[nameof(dgvtbcNRecordBook), e.RowIndex].Value.ToString()).Show();
    }
}
