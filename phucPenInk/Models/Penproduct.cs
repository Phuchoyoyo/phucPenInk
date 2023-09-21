using phucPenInk.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace phucPenInk.Models
{
    public class Penproduct
    {
        //movies

        [Key]

        public int Id { get; set; }

        public string penName { get; set; } 

        public string penDescription { get; set; }  

        public double price { get; set; }   

        public string imageurl { get; set; }

        public DateTime startdate { get; set; } 

        public DateTime enddate { get; set; }   

        public Pentype Pentype { get; set; }

        public List<Producer_ProductProducer> Producer_ProductProducer { get; set; }


        //pens

        public int PensId { get; set; }
        [ForeignKey("PensId")]
        public Pens Pens { get; set; }

        //prodcuer
        public int ProducerId { get; set; }
        [ForeignKey("PensId")]
        public Producer Producer { get; set; }
    }
}
