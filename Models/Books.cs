using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aman_WebAPI.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        public int Ratings { get; set; }
        public decimal Price { get; set; }
    }
}
