using movie_Ecommerce_App.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Models
{
    public class Producer : IEntityBase
    {
       

        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50,MinimumLength = 3, ErrorMessage ="Full Name must be between 3 and 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biogrphy is required")]
        public string Bio { get; set; }

        //Relationships(One to many relationship)
        //Note a producer can produce multiple movies, but a movie can only have one producer
        public List<Movie> Movies { get; set; }
    }
}
