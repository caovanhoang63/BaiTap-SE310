using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BT1.Model;
using BT1.Repo;

namespace BT1.DA.Ado
{
    public class AdoStore : IAnimalRepo
    {
        private readonly string _connectionString = "Data Source=baitap1.sqlite;";
        public AdoStore()
        {
            
        }


        public void GetMilk(int l)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO TABLE LichSuLaySua(so_lit_sua) values (@so_lit_sua) ";
                    command.Parameters.Add(new SqlParameter("@so_lit_sua", l));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddAnimals(List<Animal> animals)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO DongVat (id, type) VALUES (@id, @type)";
                        var idParam = command.Parameters.Add("@id", SqlDbType.Text);
                        var typeParam = command.Parameters.Add("@type", SqlDbType.Int);

                        foreach (var animal in animals)
                        {
                            idParam.Value = animal.Id.ToString();
                            typeParam.Value = (int)animal.AnimalType;
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
            }
        }

        public List<Animal> GetAllAnimals()
        {
            var animals = new List<Animal>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT * FROM TABLE DongVat";
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Guid guid = Guid.Parse(reader["integ_schemehistoryId"].ToString());
                        Enum.TryParse(reader["type"].ToString(), out AnimalType animalType);
                        Animal animal;
                        switch (animalType)
                        {
                            case AnimalType.Cow:
                                animal= new Cow(guid);
                                break;
                            case AnimalType.Sheep:
                                animal= new Sheep(guid);
                                break;
                            case AnimalType.Goat:
                                animal= new Goat(guid);
                                break;
                            default:
                                animal = null;
                                break;
                        }
                        animals.Add(animal);
                    }
                }
            }

            return animals;
        }

        public void AddAnimal(Animal animal)
        {
            
            
        }
    }
}