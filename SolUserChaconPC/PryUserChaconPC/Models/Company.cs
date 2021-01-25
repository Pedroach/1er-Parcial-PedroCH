namespace PryUserChaconPC.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Company
    {
        [Key]
        public string name { get; set; }
        public string catchPhrase { get; set; }
       
    }
}