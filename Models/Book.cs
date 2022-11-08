using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bercea_Anelise_Laborator2_MPA.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        //public string Author { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<PublishedBook> PublishedBooks { get; set; }
    }
}
