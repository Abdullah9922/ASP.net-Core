using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
