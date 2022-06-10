using System.ComponentModel.DataAnnotations;

namespace dotnet_3.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Imię")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Proszę wypełnić to pole")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]

        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Display(Name = "Rok")]
        [Required(ErrorMessage = "Proszę wypełnić to pole"), Range(1899, 2022, ErrorMessage = "Oczekiwana wartość z zakresu {1} i {2}.")]
        public int Year { get; set; }

        [Display(Name = "Data")]
        public DateTime? Date { get; set; }

        public bool LeapYear { get; set; }
        [Display(Name = "Rok przestępny")]
        public string? Result { get; set; }

        public void isLeap()
        {
            if (DateTime.IsLeapYear(Year))
            {
                LeapYear = true;
                Result = "rok przestępny";
            }
            else
            {
                LeapYear = false;
                Result = "rok nie był przestępny";
            }
        }

        public string ToStringLastSearched()
        {
            return Name + " " + LastName + ", " + Year + " - " + Result + " " + Date;
        }

        public string ToStringSession()
        {
            return Name + ", " + Year + " - " + Result;
        }

        public bool CompareDate(DateTime date1, DateTime date2)
        {
            return date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year;
        }
    }
}
