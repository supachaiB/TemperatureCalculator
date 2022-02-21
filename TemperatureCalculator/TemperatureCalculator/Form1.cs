namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvertCtoF_Click(object sender, EventArgs e)
        {
            string input = textBoxC.Text;

            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            textBoxF.Text = f.ToString();
        }

        private void buttonConvertFtoC_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBoxF.Text);
            double c = (f - 32) * 5 / 9;
            //show input to textbox
            textBoxC.Text = c.ToString();
        }

        
    }
}