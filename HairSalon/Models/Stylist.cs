using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Customer = new HashSet<Customer>();
        }
        public int StylistId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}