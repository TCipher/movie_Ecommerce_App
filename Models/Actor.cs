using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full Name Must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships(Many to many)
        //Note: An actor can act in  multiple movies and a movie can have multiple actors
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
