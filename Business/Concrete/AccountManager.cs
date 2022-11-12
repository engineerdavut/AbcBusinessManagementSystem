using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountManager : AccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        public void Add(Account account)
        {
            _accountDal.Add(account);
        }

        public void Delete(Account account)
        {
            _accountDal.Delete(account);
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }

        public Account GetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void Update(Account account)
        {
            _accountDal.Update(account);
        }
    }
}
