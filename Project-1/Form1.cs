namespace Project_1
{
    public partial class Form1 : Form
    {
        int numGlobalValue = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bcomando_Click(object sender, EventArgs e)
        {
            int numLocalValue = 5;
            MessageBox.Show("Variable Global es " + numGlobalValue);
            MessageBox.Show("Variable Local es " + numLocalValue);
            MessageBox.Show("Hola mundo, ahora el valor " + otraF(100+numGlobalValue));

        }

        static int otraF(int input)
        {
            return input + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}