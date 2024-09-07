namespace BasicQueueingCashier
{
    public partial class QueueingForm : Form
    {
        private int casheir;

        public QueueingForm()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CasheirClass casheir = new CasheirClass();

            lblQueue.Text = casheir.CashierGeneratedNumber("P - ");
            CasheirClass.getNumberInQueue = lblQueue.Text;
            CasheirClass.CashierQueue.Enqueue(CasheirClass.getNumberInQueue);

            Cashier cashiesr = new Cashier();
            cashiesr.ShowDialog();

        }

        private void QueueingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
