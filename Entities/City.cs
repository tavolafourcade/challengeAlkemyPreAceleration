using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.PreAceleracion.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }

        //Relation to Continent
        public Continent Continent { get; set; }

        //Relation to GeographicIcons
        public ICollection<GeographicIcons> GeographicIcons { get; set; }

    }
}
