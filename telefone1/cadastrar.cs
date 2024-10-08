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
    public partial class cadastrar : Form
    {
        int enabled = 0;
        int enabled1 = 0;
        public cadastrar()
        {
            InitializeComponent();
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

            cadastrarBTN.Enabled = false;
        }

        private void cadastrar_enabled()
        {

            //seguintes condições: usuário preenchido, senha preenchida e telefone.
            cadastrarBTN.Enabled = (UsuárioCreate.Text.Length > 0 && SenhaCreate.Text.Length >= 8 && TelefoneCreate.Text.Length == 11);
        }

        private void UsuárioCreate_TextChanged(object sender, EventArgs e)
        {

            cadastrar_enabled();
        }

        private void SenhaCreate_TextChanged(object sender, EventArgs e)
        {

            cadastrar_enabled();
        }

        private void TelefoneCreate_TextChanged(object sender, EventArgs e)
        {

            cadastrar_enabled();
        }
    }
}
