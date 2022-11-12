using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TeamOfAccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TeamId { get; set; }
    }
}
