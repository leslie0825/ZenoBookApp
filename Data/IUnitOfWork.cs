﻿using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOfWork : IDisposable
    {
        IBooksRepository BooksRepository { get; }
        void Commit();

    }
}
