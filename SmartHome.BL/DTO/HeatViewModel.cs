using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.BL.DTO
{
    public class HeatViewModel
    {
        public Guid Id { get; set; }

        public Type Type { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public bool Condition { get; set; }

        public int Temperature { get; set; }

        public int MinTemperature { get; set; }

        public int MaxTemperature { get; set; }
    }
}
