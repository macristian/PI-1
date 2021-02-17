using System.Collections.Generic;
using MySqlConnector;

namespace Scisense.Models
{
    public class ContatoRepository : Repository
    {
        public void Insert(Contato novoCont)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO inbox (Name, Email, ContactNum, Subject, Message, Readed) VALUES (@Name, @Email, @ContactNum, @Subject, @Message, 'https://support.orcid.org/hc/article_attachments/360053920013/sofia_inbox.jpg')";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Name", novoCont.Name);
            comando.Parameters.AddWithValue("@Email", novoCont.Email);
            comando.Parameters.AddWithValue("@ContactNum", novoCont.ContactNum);
            comando.Parameters.AddWithValue("@Subject", novoCont.Subject);
            comando.Parameters.AddWithValue("@Message", novoCont.Message);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Contato> Query()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM inbox";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            List<Contato> lista = new List<Contato>();
            while (reader.Read())
            {
                Contato cont = new Contato();
                cont.Id = reader.GetInt32("Id");
                if (!reader.IsDBNull(reader.GetOrdinal("Name")))
                    cont.Name = reader.GetString("Name");
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                    cont.Email = reader.GetString("Email");
                if (!reader.IsDBNull(reader.GetOrdinal("ContactNum")))
                    cont.ContactNum = reader.GetString("ContactNum");
                if (!reader.IsDBNull(reader.GetOrdinal("Subject")))
                    cont.Subject = reader.GetString("Subject");
                if (!reader.IsDBNull(reader.GetOrdinal("Message")))
                    cont.Message = reader.GetString("Message");
                if (!reader.IsDBNull(reader.GetOrdinal("Readed")))
                    cont.Readed = reader.GetString("Readed");
                lista.Add(cont);
            }
            conexao.Close();
            return lista;
        }
        public void Excluir(Contato excluiCont)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "DELETE FROM inbox WHERE Id = @Id";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", excluiCont.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Editar(Contato editarCont)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "UPDATE inbox SET Readed = 'https://www.mailbiz.com.br/wp-content/uploads/bfi_thumb/double-optin-email-marketing-2z7n56q1ezaqnhjn1je78s89oc65an2gb4q28m6xmnkbm9akw.jpg' WHERE Id = @Id;";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", editarCont.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}