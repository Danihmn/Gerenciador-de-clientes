using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de insercao
    /// <summary>
    /// Classe responsável por inserir dados no banco
    /// </summary>
    public class Insercao
    {
        #region Insere novos clientes
        /// <summary>
        /// Método responsável por inserir dados no banco
        /// </summary>
        /// <param name="nome">Nome a ser inserido</param>
        /// <param name="email">E-mail a ser inserido</param>
        /// <param name="telefone">Telefone a ser inserido</param>
        public static void InserirDados(string nome, string email, string telefone)
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
                    throw;
                }
            }
        }
        #endregion
    }
    #endregion
}
