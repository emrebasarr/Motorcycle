using CA_Motorcycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CA_Motorcycle.Repository
{
    internal class MotorcycleRepository : IMotorcycleRepository
    {
        MotorcycleDbContext mcbt = new MotorcycleDbContext();

        public void AddMotorcycle(Motorcycle motorcycle)
        {
           mcbt.Motorcycles.Add(motorcycle);
           mcbt.SaveChanges();
        }

        public void DeleteMotorcycle(int id)
        {
            var result = mcbt.Motorcycles.Where(x => x.Id == id).FirstOrDefault();
            mcbt.Motorcycles.Remove(result);
            mcbt.SaveChanges();
        }

        public List<Motorcycle> GetMotorcycle()
        {
            var result = mcbt.Motorcycles.ToList();
            return result;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            mcbt.Update(motorcycle);
            mcbt.SaveChanges();
        }
    }
}