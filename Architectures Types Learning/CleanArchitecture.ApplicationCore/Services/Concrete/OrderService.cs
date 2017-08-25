using CleanArchitecture.ApplicationCore.Entities;
using CleanArchitecture.ApplicationCore.Repositories;
using CleanArchitecture.ApplicationCore.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.ApplicationCore.Services.Concrete
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeOrder(Order order)
        {
            Phone phone = Database.Phones.Get(order.PhoneId);

            if (phone == null)
                throw new Exception("Phone was not found");

            var discountPrice = phone.Price * 100 / 10;
            order.Sum = discountPrice;

            Database.Orders.Create(order);
            Database.Save();
        }

        public IEnumerable<Phone> GetPhones()
        {
            return Database.Phones.GetAll();
        }

        public Phone GetPhone(int? id)
        {
            if (id == null)
                throw new Exception("Data is invalid");

            var phone = Database.Phones.Get(id.Value);
            if (phone == null)
                throw new Exception("Phone was not found");

            return phone;
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
