using NotesApplication.UseCases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.UseCases.Stores
{
    public interface IAccountStore
    {
        Account GetCurrentAccount();
        void Update(Account account);
    }
}
