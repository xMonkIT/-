using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class AddStudentDialog : Form
    {
        public AddStudentDialog()
        {
            InitializeComponent();
        }

        private void AddStudentDialog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.SGroup". При необходимости она может быть перемещена или удалена.
            this.sGroupTableAdapter.Fill(this.dsProgress.SGroup);

        }
    }
}
