using System.Data;
using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de verificacoes, para maior seguranca no tratamento dos dados
    /// <summary>
    /// Classe responsável por verificações de existência de dados no banco
    /// </summary>
    public class Verificacao
    {
        #region Verifica a existência de um dado atraves do seu id
        /// <summary>
        /// Método responsável por verificar a existência de registro pelo seu id
        /// </summary>
        /// <param name="id">Id do cliente a ser verificado</param>
        /// <returns>Verdadeiro se existir, falso caso contrário</returns>
        public static bool VerificarPorId(string id)
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
                    throw;
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
        /// <summary>
        /// Método responsável por verificar a existência de registro pelo seu email
        /// </summary>
        /// <param name="email">E-mail do cliente a ser verificado</param>
        /// <returns>Verdadeiro se existir, falso caso contrário</returns>
        public static bool VerificarPorEmail(string email)
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
                    throw;
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
        /// <summary>
        /// Método responsável por verificar a existência de registro pelo seu telefone
        /// </summary>
        /// <param name="telefone">Telefone do cliente a ser verificado</param>
        /// <returns>Verdadeiro se existir, falso caso contrário</returns>
        public static bool VerificarPorTelefone(string telefone)
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
                    throw;
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
