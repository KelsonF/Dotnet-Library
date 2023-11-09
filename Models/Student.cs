using System.ComponentModel.DataAnnotations;

namespace dotnet_library.Models
{
    public class Student:Member
    {
        [Display(Name = "Student College")]
        public string? studentCollege { get; set; }

        public void CheckoutBook() {
            Console.WriteLine("Book Checked Out");
        }

        public new void ReturnBook() {
            Console.WriteLine("Book Returned");
        }
    }
}