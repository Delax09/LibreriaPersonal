using System.ComponentModel.DataAnnotations;

namespace BackendBooks.models{
    public class Book
    {
        [Key]
        public int Idbook{get;set;}
        public required string Title{get;set;}
        public required string Author {get; set; }
        public required string isbn {get; set; }
        public required int PublishedYear {get; set;}
        public required int Price{get;set;}
    }
}