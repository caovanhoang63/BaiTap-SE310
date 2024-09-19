using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using BT1.Model;
using BT1.Repo;

namespace BT1.DA.Ado
{
    public class AdoStore : IAnimalRepo
    {
        private readonly string _connectionString = @"Data Source=C:\Users\caova\RiderProjects\BaiTap-SE310\baitap1.sqlite;Version=3;";
        public AdoStore()
        {
            
        }

        public void ProduceMilk(int l)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO LichSuLaySua(so_lit_sua) VALUES (@so_lit_sua)";
                    command.Parameters.AddWithValue("@so_lit_sua", l);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetMilk()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
        
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT IFNULL(SUM(so_lit_sua), 0) FROM LichSuLaySua";
            
                    var result = command.ExecuteScalar();
            
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    return 0;
                }
            }
        }

        public void AddAnimals(List<Animal> animals)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO DongVat (id, type) VALUES (@id, @type)";
                        var idParam = command.Parameters.Add("@id", DbType.String);
                        var typeParam = command.Parameters.Add("@type", DbType.Int32);

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
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM DongVat";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid guid = Guid.Parse(reader["id"].ToString());
                            Enum.TryParse(reader["type"].ToString(), out AnimalType animalType);
                            Animal animal;
                            switch (animalType)
                            {
                                case AnimalType.Cow:
                                    animal = new Cow(guid);
                                    break;
                                case AnimalType.Sheep:
                                    animal = new Sheep(guid);
                                    break;
                                case AnimalType.Goat:
                                    animal = new Goat(guid);
                                    break;
                                default:
                                    animal = null;
                                    break;
                            }
                            animals.Add(animal);
                        }
                    }
                }
            }

            return animals;
        }

        public void AddAnimal(Animal animal)
        {
            // Implementation not provided in the original code
        }
    }
}