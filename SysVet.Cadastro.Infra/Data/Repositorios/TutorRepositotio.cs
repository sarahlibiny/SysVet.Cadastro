using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using SysVet.Cadastro.Infra.Data.Entidades;

namespace SysVet.Cadastro.Infra.Data.Repositorios
{
    public class TutorRepositotio
    {
        public IDbConnection _connection;
        public TutorRepositotio(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<Tutor> Get()
        {
            return _connection.Query<Tutor>("SELECT * FROM TUTOR").ToList();
        }

        public Tutor Get(int id)
        {
            return _connection.QueryFirstOrDefault<Tutor>("SELECT * FROM TUTOR WHERE Id = @id", new { id });
        }

        public void Insert(Tutor tutor)
        {
            var query = "INSERT INTO Tutor(Nome) VALUES (@Nome)";
            _connection.Execute(query, new { tutor });
        }

        public void Update(Tutor tutor)
        {
            var query = "UPDATE Tutor SET Nome = @nome WHERE Id = @id";
            _connection.Execute(query, new { nome = tutor.Nome, id = tutor.Id });
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM Tutor WHERE Id = @id";
            _connection.Execute(query, new { id });
        }
    }
}
