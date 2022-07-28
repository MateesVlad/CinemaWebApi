﻿using System.ComponentModel.DataAnnotations;

namespace CinemaWebApi.Entities
{
    public class Users
    {
        [Key]
         
        public Guid ID { get; set; }

        [MaxLength(150)]

        public string FirstName { get; set; }

        [MaxLength(150)]

        public string LastName { get; set; }

        [Required]

        public string Email { get; set; }

        [Required]

        public string Password { get; set; }
   

        public bool? Delete { get; set; }

    }
}
