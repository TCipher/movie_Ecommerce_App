using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }

        public double Price { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public  Movie movie { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order order { get; set; }

    }
}
