using MySql.Data.MySqlClient;
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

            //seguintes condições: usuário preenchido, senha preenchida, telefone e nome.
            cadastrarBTN.Enabled = (UsuárioCreate.Text.Length > 0 && SenhaCreate.Text.Length >= 8 && TelefoneCreate.Text.Length != 0 && nomeBox.Text.Length > 0);
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

        private void cadastrarBTN_Click(object sender, EventArgs e)
        {

            //esse aqui insere as informações pra conexão e cria a conexão
            MySqlConnection conecta = new MySqlConnection("server=127.0.0.1;Database=bdtelefone; User ID =root; password = root");

            //estes abrem a conexão e criam o comando em sql pra inserir o usuário
            conecta.Open();
            string SQL = $"INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES ('{nomeBox.Text}', '{UsuárioCreate.Text}', '{TelefoneCreate.Text}', '{SenhaCreate.Text}')";
            
            //esse aqui executa o código
            MySqlCommand comma = new MySqlCommand(SQL, conecta);
            comma.ExecuteNonQuery();

            //não sei se qualquer coisa disso ta certo
            conecta.Close();


            MessageBox.Show("cadastrado com sucesso!");
        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {
            cadastrar_enabled();
        }
    }
}
