using System.Collections.Generic;

namespace UnicornStore.Models
{
    public class Unicorn : BaseEntity
    {
        public string Name { get; set; }
        public List<Power> Powers { get; set; }
    }
}