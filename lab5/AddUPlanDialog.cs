using System.Windows.Forms;

namespace lab5
{
    public partial class AddUPlanDialog : Form
    {
        public AddUPlanDialog()
        {
            InitializeComponent();
        }

        private void AddUPlanDialog_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dsProgress.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.SGroup". При необходимости она может быть перемещена или удалена.
            this.sGroupTableAdapter.Fill(this.dsProgress.SGroup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Work". При необходимости она может быть перемещена или удалена.
            this.workTableAdapter.Fill(this.dsProgress.Work);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsProgress.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.dsProgress.Subject);

        }
    }
}
