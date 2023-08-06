using CA_Motorcycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Motorcycle.Repository
{
    internal interface IMotorcycleRepository
    {

        public List<Motorcycle> GetMotorcycle();
        void AddMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int id);
    }
}
