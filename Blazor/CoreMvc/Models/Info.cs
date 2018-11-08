using System.ComponentModel.DataAnnotations;

namespace CoreMvc.Information
{
    public class Information
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int Age { get; set; }
    }
}