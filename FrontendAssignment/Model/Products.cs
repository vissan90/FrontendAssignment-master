using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendAssignment.Model
{
    public class Products
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }

        [Required]
        public string Price { get; set; }

        public int Clicks { get; set; }

        public string ImageSrc { get; set; }

        public string Description { get; set; }
    }
}
