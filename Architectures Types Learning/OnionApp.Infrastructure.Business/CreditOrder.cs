using OnionApp.Domain.Core;
using OnionApp.Services.Interfaces;

namespace OnionApp.Infrastructure.Business
{
    public class CreditOrder : IOrder
    {
        public void MakeOrder(Book book)
        {
            // код покупки книги с помощью кредитной карты
        }
    }
}