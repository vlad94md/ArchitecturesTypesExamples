using CleanArchitecture.ApplicationCore.Entities;
using System;

namespace CleanArchitecture.ApplicationCore.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Phone> Phones { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
