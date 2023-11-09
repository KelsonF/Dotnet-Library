using System.ComponentModel.DataAnnotations;

namespace dotnet_library.Models
{
    public class Alert
    {
        [Display(Name = "Alert ID")]
        public int Id { get; set; }
        [Display(Name = "Issue Date")]
        public DateOnly IssueDate { get; set; }
        [Display(Name = "Book Name")]
        public string? BookName { get; set; }
        public DateOnly ReturnDate { get; set; }
        [Display(Name = "Return Date")]
        public int Fine { get; set; }

        public int FineCall()
        {
            return 0;
        }

        public void ViewAlert()
        {
            Console.WriteLine("Alert Viewed");
        }

        public void SendToLibrarian()
        {
            Console.WriteLine("Alert Sent");
        }

        public void DeleteAlert()
        {
            Console.WriteLine("Alert Deleted");
        }
    }
}