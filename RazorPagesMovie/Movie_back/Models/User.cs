using System.ComponentModel.DataAnnotations;



namespace Movie_Back.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Latin letters only")]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$", ErrorMessage = "Invalid email address entered")]
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public string PhotoPath { get; set; }
        public Country? Country { get; set; }
    }
}