using System.ComponentModel.DataAnnotations;

namespace phucPenInk.Models
{
    public class Pens
    {
        //cinema

        [Key]
        public int Id { get; set; }

       public string pictureUrl { get; set; }

        public string productName { get; set; }

        public string description { get; set; }

        public List<Penproduct> Pen { get; set; }    

    }
}
