using ProvaAPI.Context;
using ProvaAPI.Interfaces.Repositories;
using ProvaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAPI.Repositories
{
    public class AutomobileRepository : IAutomobileRepository
    {
        private readonly DatabaseContext context;
        public AutomobileRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public Automobile Create(Automobile automobile)
        {
            context.Add(automobile);
            context.SaveChanges();
            return automobile;
        }
        public IEnumerable<Automobile> GetAll()
        {
            return context.Automobiles.ToList();
        }

    }
}
