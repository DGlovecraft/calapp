namespace appcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // �ŧ��ͤ����繨ӹǹ������Ǻǡ�ѹ
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 + num2;

            // �ʴ����Ѿ��� text box r
            r.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // �ŧ��ͤ����繨ӹǹ������Ǻǡ�ѹ
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 * num2;

            // �ʴ����Ѿ��� text box r
            r.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // �ŧ��ͤ����繨ӹǹ������Ǻǡ�ѹ
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 / num2;

            // �ʴ����Ѿ��� text box r
            r.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // �ŧ��ͤ����繨ӹǹ������Ǻǡ�ѹ
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 - num2;

            // �ʴ����Ѿ��� text box r
            r.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            r.Text = "";
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
