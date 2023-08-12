using System.ComponentModel.DataAnnotations;

namespace CoffwshopMVC.Models
{
    public class ReservationModel
    {

        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        //[Range(5,100)]
        public string Date { get; set; }


        [Required]
        //[Range(5,100)]
        public string Time { get; set; }



        [Required]
        public String Person { get; set; }
    }
}
