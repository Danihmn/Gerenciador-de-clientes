using System.Data;
using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de conexao
    internal class Conexao
    {
        #region Obtem a conexao com o banco
        public static SQLiteConnection ObterConexao()
        {
            SQLiteConnection conexao = new SQLiteConnection(@"Data Source = C:\\Users\\danie\\Dev.NET\\Estudos\\AppBancoDeDados\\database.db");
            conexao.Open(); // Abre a conexão

            return conexao;
        }
        #endregion
    }
    #endregion

    #region Sessao de consultas
    public class Consulta
    {
        #region Consulta todos os clientes
        public static DataTable ConsultaTodos()
        {
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes;";

                    // Instancia novo Adapter, passando o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable);// Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a consulta de todos os clientes. " + ex.Message);
                    System.Environment.Exit(0);
                }
            }

            return dataTable;
        }
        #endregion

        #region Consulta o nome do cliente atraves do id
        public static DataTable ConsultaPorId(object id)
        {
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE id = @id;";
                    comando.Parameters.AddWithValue("@id", id); // Uso de parâmetros para segurança

                    // Instancia novo Adapter, passando o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a consulta por id. " + ex.Message);
                    System.Environment.Exit(0);
                }
            }

            return dataTable;
        }
        #endregion

        #region Consulta o id do cliente atraves do nome
        public static DataTable ConsultaPorNome(object nome)
        {
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE nome = @nome;";
                    comando.Parameters.AddWithValue("@nome", nome); // Uso de parâmetros para maior segurança

                    // Instancia novo Adapter e insere o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a consulta por nome. " + ex.Message);
                    System.Environment.Exit(0);
                }

                return dataTable;
            }
        }
        #endregion
    }
    #endregion

    #region Sessao de insercao
    public class Insercao
    {
        #region Insere novos clientes
        public static void InserirDados(object nome, object email, object telefone)
        {
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "INSERT INTO clientes (nome, email, telefone) VALUES(" +
                        "@nome," +
                        "@email," +
                        "@telefone);";

                    // Uso de parâmetros para melhor segurança
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.ExecuteNonQuery(); // Executa o comando, sem retorno
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a inserção. " + ex.Message);
                    return;
                }
            }
        }
        #endregion
    }
    #endregion

    #region Sessao de remocao
    public class Remocao
    {
        #region Remove clientes com base no id
        public static void RemoverDados(object id)
        {
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    // Acessa a conexão e cria novo comando
                    var comando = conexao.CreateCommand();

                    comando.CommandText = "DELETE FROM clientes WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", id); // Uso de parâmetro para melhor segurança
                    comando.ExecuteNonQuery(); // Executa o comando, sem retorno
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir os dados. " + ex.Message);
                    return;
                }
            }
        }
        #endregion
    }
    #endregion

    #region Sessao de verificacoes, para maior seguranca no tratamento dos dados
    public class Verificacao
    {
        #region Verifica a existência de um dado atraves do seu id
        public static bool VerificarPorId(object id)
        {
            bool existe;
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE id = @id;";
                    comando.Parameters.AddWithValue("@id", id); // Uso de parâmetros para segurança

                    // Instancia novo Adapter e insere o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar a existência dos dados. " + ex.Message);
                    System.Environment.Exit(0);
                }
            }

            // Verificação
            if (dataTable.Rows.Count > 0)
                existe = true;
            else
                existe = false;

            return existe;
        }
        #endregion

        #region Verifica a existência de um dado atraves do seu email
        public static bool VerificarPorEmail(object email)
        {
            bool existe;
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE email = @email;";
                    comando.Parameters.AddWithValue("@email", email); // Uso de parâmetros para segurança

                    // Instancia novo Adapter e insere o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar a existência dos dados. " + ex.Message);
                    System.Environment.Exit(0);
                }
            }

            // Verificação
            if (dataTable.Rows.Count > 0)
                existe = true;
            else
                existe = false;

            return existe;
        }
        #endregion

        #region Verifica a existência de um dado atraves do seu telefone
        public static bool VerificarPorTelefone(object telefone)
        {
            bool existe;
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE telefone = @telefone;";
                    comando.Parameters.AddWithValue("@telefone", telefone); // Uso de parâmetros para segurança

                    // Instancia novo Adapter e insere o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar a existência dos dados. " + ex.Message);
                    System.Environment.Exit(0);
                }
            }

            // Verificação
            if (dataTable.Rows.Count > 0)
                existe = true;
            else
                existe = false;

            return existe;
        }
        #endregion
    }
    #endregion
}
