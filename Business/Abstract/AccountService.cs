using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface AccountService
    {
        Account GetById(int id);
        void Add(Account account);
        void Update(Account account);

        void Delete(Account account);
        List<Account> GetAll();
    }
}
