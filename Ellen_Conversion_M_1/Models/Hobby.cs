﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ellen_Conversion_M_1.Models
{
    public class Hobby
    {
        [Key]
        public int Id{ get; set;}
        public string Name { get; set; }
        public bool IsActive { get; set; }
        //public virtual ICollection<UserDemographics UserDemographics> { get; set; }

    }
}