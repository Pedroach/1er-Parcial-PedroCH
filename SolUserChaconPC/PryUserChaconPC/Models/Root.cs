namespace PryUserChaconPC.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Root
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100,ErrorMessage = "Nombre debe contener de 5 a 100 caracteres", MinimumLength =5)]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public Address address { get; set; }
        [Required]
        [Phone]
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }
}