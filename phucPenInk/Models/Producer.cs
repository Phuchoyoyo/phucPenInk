using System.ComponentModel.DataAnnotations;

 namespace phucPenInk.Models

{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string pictureUrl { get; set; }

        public string productName { get; set; }

        public string description { get; set; }
    }
}
