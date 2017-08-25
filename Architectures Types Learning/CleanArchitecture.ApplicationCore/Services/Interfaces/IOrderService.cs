using CleanArchitecture.ApplicationCore.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.ApplicationCore.Services.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(Order orderDto);
        Phone GetPhone(int? id);
        IEnumerable<Phone> GetPhones();
        void Dispose();
    }
}
