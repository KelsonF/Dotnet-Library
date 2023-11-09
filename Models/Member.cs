using System.ComponentModel.DataAnnotations;

namespace dotnet_library.Models;

public class Member
{
  [Display(Name = "Member ID")]
  public int Id { get; set; }
  [Display(Name = "Name")]
  public string? Name { get; set; }
  [Display(Name = "Adress")]
  public string? Adress { get; set; }
  [Display(Name = "Phone")]
  public int Phone { get; set; }
  [Display(Name = "Books")]
  public virtual ICollection<Book>? Books { get; set; }

  public void RequestForBook()
  {
    Console.WriteLine("Book Requested");
  }

  public void ReturnBook()
  {
    Console.WriteLine("Book Returned");
  }
}
