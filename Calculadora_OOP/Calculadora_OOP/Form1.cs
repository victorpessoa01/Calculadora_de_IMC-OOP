namespace Calculadora_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Calculadora obC = new Calculadora();
            obC.num1 = double.Parse(textBoxNum1.Text);   
            obC.num2 = double.Parse(textBoxNum2.Text);

            obC.Soma();
            labelValor.Text = Convert.ToString(obC.Soma());

        }

        private void buttonSubt_Click(object sender, EventArgs e)
        {
            Calculadora obC = new Calculadora();
            obC.num1 = double.Parse(textBoxNum1.Text);
            obC.num2 = double.Parse(textBoxNum2.Text);

            obC.Subt();
            labelValor.Text = Convert.ToString(obC.Subt());
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            Calculadora obC = new Calculadora();
            obC.num1 = double.Parse(textBoxNum1.Text);
            obC.num2 = double.Parse(textBoxNum2.Text);

            obC.Divi();
            labelValor.Text = Convert.ToString(obC.Divi());
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Calculadora obC = new Calculadora();
            obC.num1 = double.Parse(textBoxNum1.Text);
            obC.num2 = double.Parse(textBoxNum2.Text);

            obC.Multi();
            labelValor.Text = Convert.ToString(obC.Multi());
        }

        private void buttonSaida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}