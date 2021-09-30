using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAPI.Models
{
    public class Automobile
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Chassi { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public int FactoryYear { get; set; }


    }
}
