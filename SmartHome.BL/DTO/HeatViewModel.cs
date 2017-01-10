using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.BL.DTO
{
    public class HeatViewModel
    {
        public Guid Id { get; set; }

        public string TypeName { get; set; }

        [Required(ErrorMessage = "Name must not be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location must not be empty")]
        public string Location { get; set; }

        public bool Condition { get; set; }

        [DisplayName("Minimum Temperature")]
        [Range(0, 100, ErrorMessage = "Allowable range is 0 - 100")]
        public int Temperature { get; set; }

        [DisplayName("Minimum Temperature")]
        [Range(0, 100, ErrorMessage = "Allowable range is 0 - 100")]
        public int MinTemperature { get; set; }

        [DisplayName("Maximum Temperature")]
        [Range(0, 100, ErrorMessage = "Allowable range is 30 - 100")]
        public int MaxTemperature { get; set; }
    }
}
