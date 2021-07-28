using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.PreAceleracion.Entities
{
    public class Continent
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }

        // Relation to Cities
        public ICollection<City> Cities { get; set; }
    }
}
