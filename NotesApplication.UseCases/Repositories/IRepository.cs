﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.UseCases.Repositories
{
    public interface IRepository
    {
        Task Save();
    }
}
