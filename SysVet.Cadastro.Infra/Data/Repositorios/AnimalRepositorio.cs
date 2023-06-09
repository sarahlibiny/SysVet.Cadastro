﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using SysVet.Cadastro.Dominio.Entidades;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Infra.Data.Repositorios
{
    public class AnimalRepositorio : IAnimalRepositorio
    {
        public IDbConnection _connection;

        public AnimalRepositorio(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<Animal> Get()
        {
            return _connection.Query<Animal>("SELECT * FROM Animal").ToList();
        }

        public Animal Get(int id)
        {
            var query = "SELECT * FROM Animal WHERE Id = @id";
            return _connection.QueryFirstOrDefault<Animal>(query, new { id });
        }

        public void Insert(Animal animal)
        {
            var query = "INSERT INTO Animal (Nome, Raça, DataNascimento, TutorId) VALUES (@Nome, @Raça, @DataNascimento, @TutorId)";
            _connection.Execute(query, animal);
        }

        public void Update(Animal animal)
        {
            var query = @"  UPDATE 
                                Animal 
                            SET 
                                Nome = @nome, 
                                Raça = @Raça,
                                DataNascimento = @DataNascimento 
                            WHERE 
                                Id = @id";
            _connection.Execute(query, animal);
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM Animal WHERE Id = @id";
            _connection.Execute(query, new { id });
        }
    }
}
