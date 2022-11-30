using MySql.Data.MySqlClient;

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

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=N1c0l0s.;database=db_agenda";

                //Cria conexao com MySql
                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato (nome, email, telefone) " +
                    "VALUES ('" + txt_Nome.Text 
                    + "', '" + txt_Email.Text 
                    + "', '" + txt_Telefone.Text 
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
            }finally{ conexao.Close(); }
        }
    }
}