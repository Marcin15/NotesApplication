using NotesApplication.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.Infrastructure.Repositories
{
    public class RepositoryBase : IRepository
    {
        private readonly DataContext _dataContext;

        public RepositoryBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Save()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
