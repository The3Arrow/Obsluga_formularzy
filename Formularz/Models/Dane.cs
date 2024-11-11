using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Podaj imie")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{1,}$", ErrorMessage = "Imię musi zaczynać się wielką literą i mieć co najmniej 2 znaki")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{1,}$", ErrorMessage = "Nazwisko musi zaczynać się wielką literą i mieć co najmniej 2 znaki")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Podaj email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj hasło")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$",
            ErrorMessage = "Hasło musi zawierać co najmniej osiem znaków, jedną małą literę, jedną dużą literę i jedną cyfrę")]
        public string Pwd { get; set; }
        [Required(ErrorMessage = "Powtórz hasło")]
        [Compare(nameof(Pwd), ErrorMessage = "Hasła nie są takie same")]
        public string PwdConfirmed { get; set; }
        [Required(ErrorMessage = "Podaj numer telefonu")]
        [Phone]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "Zły format telefonu")]
        public string PhoneNr { get; set; }
        [Required(ErrorMessage = "Podaj wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi być w zakresie 10 do 80")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Podaj miasto")]
        public string City { get; set; }
        public enum Cities { Krakow = 1, Warszawa = 2, Wroclaw = 3, Poznan = 4, Gdansk = 5 }


    }
}
