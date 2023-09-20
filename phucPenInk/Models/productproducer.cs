
using System.ComponentModel.DataAnnotations;

namespace phucPenInk.Models
{
    public class productproducer
    {
        [Key]

        public int Id { get; set; }   
        public string logo { get; set; }

        public string name { get; set; }   

        public string description { get; set; } 

    }
}
