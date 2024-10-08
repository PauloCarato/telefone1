namespace telefone1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                entrar_tela abra = new entrar_tela();
                abra.Show();
                this.Hide();
            }
            else
            {
                progressBar1.Value += 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }
    }
}
