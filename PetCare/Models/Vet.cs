using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetCare.Models
{
    public class Vet
    {
        [Key]
        public int VetID { get; set; }
        public string VetName { get; set; }

        public string Specialization { get; set; }

        public string Phone { get; set; }


        public string Email { get; set; }


        public string Address { get; set; }

        public int Rating { get; set; }

    
    }
}