﻿using System.ComponentModel.DataAnnotations;

namespace CinemaWebApi.ExternalModels
{
    public class UsersDTO
    {
        
        public Guid ID { get; set; }

     

        public string FirstName { get; set; }

    

        public string LastName { get; set; }

     

        public string Email { get; set; }

     
        public string Password { get; set; }

    }
}
