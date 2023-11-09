using System.ComponentModel.DataAnnotations;

namespace dotnet_library.Models
{
    public class ReferenceBook : Book
    {
        [Display(Name = "Faculty College")]
        public string? FacultyCollege { get; set; }

        public void CheckoutBook()
        {
            Console.WriteLine("Book Checked Out");
        }
    }
}