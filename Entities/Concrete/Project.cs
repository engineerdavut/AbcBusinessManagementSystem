using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ProjectName { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }

        public double Process { get; set; }

        public string Icon { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
