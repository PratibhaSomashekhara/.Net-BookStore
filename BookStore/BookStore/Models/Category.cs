﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required,StringLength(100),Display(Name="Name")]
        public string CategoryName { get; set; }
        [Display(Name ="Product Description")]
        public string description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}