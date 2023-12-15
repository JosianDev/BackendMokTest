using System;
using System.Collections.Generic;

namespace BackenMokTest.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
