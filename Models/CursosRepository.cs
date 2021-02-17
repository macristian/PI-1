using System.Collections.Generic;
using MySqlConnector;

namespace Scisense.Models
{
    public class CursosRepository : Repository
    {
        public void Insert(Cursos novoCurso)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO courses (workload, NameCourse, DetailsCourse, ThumbnailUri) VALUES (@Workload, @NameCourse, @DetailsCourse, @ThumbnailUri)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Workload", novoCurso.Workload);
            comando.Parameters.AddWithValue("@NameCourse", novoCurso.NameCourse);
            comando.Parameters.AddWithValue("@DetailsCourse", novoCurso.DetailsCourse);
            comando.Parameters.AddWithValue("@ThumbnailUri", novoCurso.ThumbnailUri);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Cursos> Query()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM courses";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            List<Cursos> lista = new List<Cursos>();
            while (reader.Read())
            {
                Cursos cours = new Cursos();
                cours.IdCourse = reader.GetInt32("IdCourse");
                if (!reader.IsDBNull(reader.GetOrdinal("NameCourse")))
                    cours.NameCourse = reader.GetString("NameCourse");
                if (!reader.IsDBNull(reader.GetOrdinal("DetailsCourse")))
                    cours.DetailsCourse = reader.GetString("DetailsCourse");
                if (!reader.IsDBNull(reader.GetOrdinal("ThumbnailUri")))
                    cours.ThumbnailUri = reader.GetString("ThumbnailUri");
                lista.Add(cours);
            }
            conexao.Close();
            return lista;
        }
        public void Excluir(Cursos excluiCursos)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "DELETE FROM courses WHERE IdCourse = @IdCourse";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@IdCourse", excluiCursos.IdCourse);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Editar(Cursos editarCursos)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "UPDATE courses SET workload = @Workload, NameCourse = @NameCourse, DetailsCourse = @DetailsCourse, ThumbnailUri = @ThumbnailUri WHERE IdCourse = @IdCourse";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@IdCourse", editarCursos.IdCourse);
            comando.Parameters.AddWithValue("@Workload", editarCursos.Workload);
            comando.Parameters.AddWithValue("@NameCourse", editarCursos.NameCourse);
            comando.Parameters.AddWithValue("@DetailsCourse", editarCursos.DetailsCourse);
            comando.Parameters.AddWithValue("@ThumbnailUri", editarCursos.ThumbnailUri);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}