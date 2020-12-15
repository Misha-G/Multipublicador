using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multipublicador.Models
{
    public class MPSourcePortal
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }

        // Foreign Key
        public int MPDealerId { get; set; }
        // Navigation property
        public virtual MPDealer MPDealer { get; set; }
    }
}