using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Models
{
    public class Producer
    {
       

        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships(One to many relationship)
        //Note a producer can produce multiple movies, but a movie can only have one producer
        public List<Movie> Movies { get; set; }
    }
}
