namespace While_Invest_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double money, taxainv, juros;
            int mes, cont = 1;

            money = double.Parse(textBox1.Text);
            juros = double.Parse(textBox2.Text);

            taxainv = juros / 100;

            mes = int.Parse(textBox3.Text);

            while (cont <= mes)
            {
                money = money + (money * taxainv);
                listBox1.Items.Add("O investimento do " + cont + "ª mês é de " + money);
                cont++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}