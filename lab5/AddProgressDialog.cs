using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class AddProgressDialog : Form
    {
        public AddProgressDialog()
        {
            InitializeComponent();
        }

        private void AddProgressDialog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dsProgress.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.dsProgress.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Report". При необходимости она может быть перемещена или удалена.
            this.reportTableAdapter.Fill(this.dsProgress.Report);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.dsProgress.Subject);

        }
    }
}
