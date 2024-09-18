using System.Data.SqlClient;
using BT1.Model;
using BT1.Repo;

namespace BT1.DA.Ado
{
    public class AdoStore : IAnimalRepo
    {
        private readonly string _connectionString = "Data Source=MSI;Initial Catalog=QUANLYTRANGTRAI;Integrated Security=True";
        public AdoStore()
        {
            
        }
        
        public void CreateNewAnimal(Animal animal)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
            }
        }
    }
}