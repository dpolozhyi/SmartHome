﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.BL.DTO
{
    public class AudioViewModel
    {
        public Guid Id { get; set; }

        public string TypeName { get; set; }

        [Required(ErrorMessage = "Name must not be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location must not be empty")]
        public string Location { get; set; }

        public bool Condition { get; set; }

        [Range(0, 100, ErrorMessage = "Allowable range is 0 - 100")]
        public int Volume { get; set; }

        [DisplayName("Minimum Volume")]
        [Range(0,100, ErrorMessage = "Allowable range is 0 - 100")]
        public int MinVolume { get; set; }

        [DisplayName("Maximum Volume")]
        [Range(0, 100, ErrorMessage = "Allowable range is 0 - 100")]
        public int MaxVolume { get; set; }
    }
}
