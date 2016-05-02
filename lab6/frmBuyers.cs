using System;
using System.Windows.Forms;

namespace lab6
{
    public partial class frmBuyers : Form
    {
        private SalesCenter sales = new SalesCenter();

        public frmBuyers()
        {
            InitializeComponent();
        }

        private void frmBuyers_Load(object sender, EventArgs e)
        {
            //sales.TestingStuff();
            sales.ShowMerchendises(cbMerchendise);
        }

        private void bSelectClients_Click(object sender, EventArgs e) =>
            sales.ShowClientsBuyedMerchendise(lbClients, cbMerchendise.SelectedItem.ToString());

        private void bSelectClientsWithDiscount_Click(object sender, EventArgs e) =>
            sales.ShowClientsCountWithDiscount(10, lCountWithDiscount);

        private void bSelectBiggestMerchendiseClient_Click(object sender, EventArgs e) =>
            sales.ShowBiggestMerchendiseClient(lBiggestMerchendiseClient);

        private void bSelectBuys_Click(object sender, EventArgs e) =>
            sales.ShowBuysHigherAvg(dgvBuys, lAvg);
    }
}
