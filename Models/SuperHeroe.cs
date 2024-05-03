using System.ComponentModel.DataAnnotations;

namespace kamui.Models
{
    internal class SuperHeroe
    {

        [Key]
        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string username { get; set; }

        public string place { get; set; }


    }
}