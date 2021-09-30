using ProvaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAPI.Interfaces.Services
{
    public interface IAutomobileServices
    {
        IEnumerable<Automobile> GetAutomobiles();
        Automobile CreateAutomobile(Automobile automobile);
    }
}
