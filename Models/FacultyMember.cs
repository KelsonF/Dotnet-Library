using System.ComponentModel.DataAnnotations;

namespace dotnet_library.Models
{
    public class FacultyMember:Member
    {
        [Display(Name = "Faculty College")]
        public string? FacultyCollege { get; set; }

        public void CheckoutBook() {
            Console.WriteLine("Livro checado !!!");
        }
    }
}