using ProvaAPI.Interfaces.Repositories;
using ProvaAPI.Interfaces.Services;
using ProvaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAPI.Services
{
    public class AutomobileService : IAutomobileServices
    {
        public readonly IAutomobileRepository automobileRepository;
        public AutomobileService(IAutomobileRepository automobileRepository)
        {
            this.automobileRepository = automobileRepository;
        }

        public Automobile CreateAutomobile(Automobile automobile)
        {
            automobileRepository.Create(automobile);
            return automobile;
        }

        public IEnumerable<Automobile> GetAutomobiles()
        {
            return automobileRepository.GetAll();
        }
    }
}
