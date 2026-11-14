using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Contracts
{
    public interface IUinitOfWork
    {
        void Save();
    }
}
