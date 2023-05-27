namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string etc, etc2, resultado;
            etc = textBox1.Text;
            etc2 = textBox2.Text;
            resultado = "Raluca se fudeu";
            label4.Text = resultado;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}