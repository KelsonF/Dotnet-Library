using System.ComponentModel.DataAnnotations;

namespace dotnet_library.Models
{
    public class Book
    {
        [Display(Name = "Book ID")]
        public int Id { get; set; }
        [Display(Name = "Book Name")]
        public string? BookName { get; set; }
        [Display(Name = "Author Name")]
        public string? AuthorName { get; set; }
        [Display(Name = "Number of Pages")]
        public int NumberOfPages { get; set; }
    }
}