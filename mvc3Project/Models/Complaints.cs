using System.ComponentModel.DataAnnotations;

namespace mvc3Project.Models
{
    public class Complaints
    {
        [Key]
        public int Cid { get; set; }

        public int Rid { get; set; }

        public string Complaint { get; set; }

        public string Replay { get; set; }

        public DateTime Date { get; set; }

        
    }
}
