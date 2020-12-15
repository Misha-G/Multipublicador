using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multipublicador.Models
{
    public class MPDealer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PC { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Market { get; set; }
        [Required]
        public int Phone_1 { get; set; }
        [Required]
        public int Phone_2 { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Email2 { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public string Guarantee { get; set; }

        public virtual ICollection<MPSourcePortal> MPSourcePortals { get; set; }
    }
}