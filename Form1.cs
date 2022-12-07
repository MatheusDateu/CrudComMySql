using MySql.Data.MySqlClient;
using System.Numerics;

namespace CrudComMySql
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (txt_CodigoAlteracao.Text == string.Empty)
            {
                MessageBox.Show("Você precisa informar um código e selecionar para ter acesso aos dados " +
                    "do usuário identificado pelo código.", "Código não informado");
            }
            else
            {
                try
                {
                    string data_source = "datasource=localhost;username=root;password=root.;database=db_agenda";

                    //Cria conexao com MySql
                    conexao = new MySqlConnection(data_source);

                    string sql = "INSERT INTO contato (nome, email, telefone) " +
                        "VALUES ('" + txt_NomeAlteracao.Text
                        + "', '" + txt_EmailAlteracao.Text
                        + "', '" + txt_TelefoneAlteracao.Text
                        + "') ";

                    //Executar comando Insert

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Deu tudo certo, inserido");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "A conexao nao funcionou");
                }
                finally { conexao.Close(); }
            }
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_LimparInsercao_Click(object sender, EventArgs e)
        {
            limparCampos('c');
        }

        private void limparCampos(char painel)
        {
            switch (painel)
            {
                case 'c':
                    txt_EmailInsercao.Text = "";
                    txt_NomeInsercao.Text = "";
                    txt_TelefoneInsercao.Text = "";
                    break;
                case 'r':
                    txt_CodigoAlteracao.Text = "";
                    txt_NomeAlteracao.Text = "";
                    txt_EmailAlteracao.Text = "";
                    txt_TelefoneAlteracao.Text = "";
                    break;
                case 'u':
                    txt_CodigoConsulta.Text = "";
                    txt_NomeConsulta.Text = "";
                    txt_EmailConsulta.Text = "";
                    txt_TelefoneConsulta.Text = "";
                    break;
                case 'd':
                    txt_CodigoExclusao.Text = "";
                    txt_NomeExclusao.Text = "";
                    txt_EmailExclusao.Text = "";
                    txt_TelefoneExclusao.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void btn_LimparAlteracao_Click(object sender, EventArgs e)
        {
            limparCampos('r');
        }

        private void btn_LimparConsulta_Click(object sender, EventArgs e)
        {
            limparCampos('u');
        }

        private void btn_LimparExclusao_Click(object sender, EventArgs e)
        {
            limparCampos('d');
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (txt_NomeInsercao.Text == string.Empty)
            {
                MessageBox.Show("Você precisa informar um nome", "Nome não informado");
            }
            else if (txt_EmailInsercao.Text == string.Empty)
            {
                MessageBox.Show("Você precisa informar um email", "Email não informado");
            }
            else if (txt_TelefoneInsercao.Text == string.Empty)
            {
                MessageBox.Show("Você precisa informar um número de telefone", "Telefone não informado");
            }
            else
            {
                try
                {
                    string data_source = "datasource=localhost;username=root;password=root.;database=db_agenda";

                    //Cria conexao com MySql
                    conexao = new MySqlConnection(data_source);

                    string sql = "INSERT INTO contato (nome, email, telefone) " +
                        "VALUES ('" + txt_NomeInsercao.Text
                        + "', '" + txt_EmailInsercao.Text
                        + "', '" + txt_TelefoneInsercao.Text
                        + "') ";

                    //Executar comando Insert

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Deu tudo certo, inserido");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "A conexao nao funcionou");
                }
                finally { conexao.Close(); }

            }
        }
    }
}