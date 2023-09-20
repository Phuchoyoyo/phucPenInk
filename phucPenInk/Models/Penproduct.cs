using phucPenInk.Data;
using System.ComponentModel.DataAnnotations;

namespace phucPenInk.Models
{
    public class Penproduct
    {
        [Key]

        public int Id { get; set; }

        public string penName { get; set; } 

        public string penDescription { get; set; }  

        public double price { get; set; }   

        public string imageurl { get; set; }

        public DateTime startdate { get; set; } 

        public DateTime enddate { get; set; }   

        public Pentype Pentype { get; set; }    


    }
}
