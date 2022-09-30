namespace TAXAPP
{
    public partial class TaxApp : Form
    {
       
        public TaxApp()
        {
            InitializeComponent();
            Text = "Windows Tax App";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmt, percent, ans;
            while(double.TryParse(textBox1.Text, out purchaseAmt))
                    {
                MessageBox.Show("Please enter numeric values");
                textBox1.Text = "0.0";
                textBox1.Focus();
            }

            inValue = textBox2.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent= double.Parse(inValue) / 100;
            ans = (purchaseAmt * percent) + purchaseAmt;
            textBox3.Text = String.Format("{0:C}", ans);
        }
    }
}