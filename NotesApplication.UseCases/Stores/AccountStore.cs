using NotesApplication.UseCases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.UseCases.Stores
{
    public class AccountStore : IAccountStore
    {
        private Account _account;

        public void Update(Account account)
        {
            _account = account;
        }

        public Account GetCurrentAccount() => _account;
    }
}
