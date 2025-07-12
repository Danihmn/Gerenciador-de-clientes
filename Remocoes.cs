using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de remocao
    /// <summary>
    /// Classe responsável por remover dados do banco
    /// </summary>
    public class Remocao
    {
        #region Remove clientes com base no id
        /// <summary>
        /// Método responsável por remover um dado do banco através do seu id
        /// </summary>
        /// <param name="id">Id do cliente que será excluído</param>
        public static void RemoverDados(string id)
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
                    throw;
                }
            }
        }
        #endregion
    }
    #endregion
}
