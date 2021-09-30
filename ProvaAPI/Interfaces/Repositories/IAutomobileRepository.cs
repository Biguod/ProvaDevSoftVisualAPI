using ProvaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAPI.Interfaces.Repositories
{
    public interface IAutomobileRepository
    {
        Automobile Create(Automobile automobile);

        IEnumerable<Automobile> GetAll();

    }
}
