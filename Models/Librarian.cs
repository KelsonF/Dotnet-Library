using System.ComponentModel.DataAnnotations;


namespace dotnet_library.Models
{
    public class Librarian
    {
         [Display(Name = "Librarian ID")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Address")]
        public string? Adress { get; set; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        public void UpdateInfo() {
            Console.WriteLine("Info Updated");
        }

        public void IssueBooks() {
            Console.WriteLine("Book Issued");
        }

        public void MemberInfo() {
            Console.WriteLine("Member Info");
        }

        public void SearchBook() {
            Console.WriteLine("Book Searched");
        }

        public void returnBook() {
            Console.WriteLine("Book Returned");
        }
    }
}