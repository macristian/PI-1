using System.Collections.Generic;
using MySqlConnector;

namespace Scisense.Models
{
    public class ConteudoRepository : Repository
    {
        public void Insert(Conteudo novoConteudo)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO contentCard (Image, Title, Content, BtnLink) VALUES (@Image, @Title, @Content, @BtnLink)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Image", novoConteudo.Image);
            comando.Parameters.AddWithValue("@Title", novoConteudo.Title);
            comando.Parameters.AddWithValue("@Content", novoConteudo.Content);
            comando.Parameters.AddWithValue("@BtnLink", novoConteudo.BtnLink);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Conteudo> Query()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM contentCard";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            List<Conteudo> lista = new List<Conteudo>();
            while (reader.Read())
            {
                Conteudo cours = new Conteudo();
                cours.Id = reader.GetInt32("Id");
                if (!reader.IsDBNull(reader.GetOrdinal("Image")))
                    cours.Image = reader.GetString("Image");
                if (!reader.IsDBNull(reader.GetOrdinal("Title")))
                    cours.Title = reader.GetString("Title");
                if (!reader.IsDBNull(reader.GetOrdinal("Content")))
                    cours.Content = reader.GetString("Content");
                if (!reader.IsDBNull(reader.GetOrdinal("BtnLink")))
                    cours.BtnLink = reader.GetString("BtnLink");
                lista.Add(cours);
            }
            conexao.Close();
            return lista;
        }
        public void Excluir(Conteudo excluiConteudo)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "DELETE FROM contentCard WHERE Id = @Id";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", excluiConteudo.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Editar(Conteudo editarConteudo)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "UPDATE contentCard SET Image = @Image, Title = @Title, Content = @Content, BtnLink = @BtnLink WHERE Id = @Id";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", editarConteudo.Id);
            comando.Parameters.AddWithValue("@Image", editarConteudo.Image);
            comando.Parameters.AddWithValue("@Title", editarConteudo.Title);
            comando.Parameters.AddWithValue("@Content", editarConteudo.Content);
            comando.Parameters.AddWithValue("@BtnLink", editarConteudo.BtnLink);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}