using System.ComponentModel.DataAnnotations;

namespace BurakAkademi.Models;

public class Candidate
{
    [Required(ErrorMessage ="Email is required")]
    public string Email { get; set; } = string.Empty;
    
    
    [Required(ErrorMessage ="FirstName is required")]
    public string FirstName { get; set; } = string.Empty;


    [Required(ErrorMessage ="LastName is required")]
    public string LastName { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName?.ToUpper()}";

    public int Age { get; set; }

    public string SelectedCourse { get; set; } = String.Empty;
    public DateTime ApplyAt { get; set; }

    public Candidate()
    {
        ApplyAt = DateTime.Now;
    }

}