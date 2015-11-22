namespace ouchernik.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tag
    {
        public Tag()
        {
            this.Questions = new HashSet<Question>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
