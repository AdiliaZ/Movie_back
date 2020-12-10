using System.ComponentModel.DataAnnotations;



namespace Movie_Back.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Country? Country { get; set; }
    }
}
