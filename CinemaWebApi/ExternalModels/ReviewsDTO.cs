using CinemaWebApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace CinemaWebApi.ExternalModels
{
    public class ReviewsDTO
    {

        

        public Guid ID { get; set; }

       
        public Guid TitleId { get; set; }

      
        public string Comment { get; set; }

    }
}
