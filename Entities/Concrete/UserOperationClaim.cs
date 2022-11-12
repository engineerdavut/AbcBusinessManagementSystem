using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class UserOperationClaim
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }

        public int UserOperationId { get; set; }
    }
}
