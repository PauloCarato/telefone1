using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefone1
{
    public partial class entrar_tela : Form
    {
        //código merda n sei fazer c#
        public entrar_tela()
        {
            InitializeComponent();
        }
        private void entrar_tela_Load(object sender, EventArgs e)
        {
                EntrarBtn.Enabled = false;
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            cadastrar abra = new cadastrar();
            abra.Show();
        }

        private void SairMenu1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entrar_tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //esses dois são redundantes, mas eu não sei se dá pra fazer de um jeito menor

        private void abilitar_Login()
        {

            //condição verdadeira = enabled true || condição falsa = enabled false
            EntrarBtn.Enabled = (UsuarioInput.Text.Length > 0 && SenhaInput.Text.Length >= 8);
        }

        private void UsuarioInput_TextChanged(object sender, EventArgs e)
        {

            abilitar_Login();          
        }

        private void SenhaInput_TextChanged(object sender, EventArgs e)
        {

            abilitar_Login();
        }

    }
}
