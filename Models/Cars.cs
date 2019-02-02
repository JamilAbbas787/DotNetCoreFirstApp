using System.ComponentModel.DataAnnotations;

namespace DotNetCoreFirstApp.Models
{
    public class Cars
    {
        [Key]
        public int ID { get; set; }
        public string Model { get; set; }

        public string Make { get; set; }    

        public int Year { get; set; }
    }
}