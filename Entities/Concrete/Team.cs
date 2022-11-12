using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    class Team
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string TeamName { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
