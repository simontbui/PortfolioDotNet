using System.ComponentModel.DataAnnotations;

namespace PortfolioDotNet.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string User { get; set; } = string.Empty;

        [Display(Name = "Comment Body")]
        public string Text { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
