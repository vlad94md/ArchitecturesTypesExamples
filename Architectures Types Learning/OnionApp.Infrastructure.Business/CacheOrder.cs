using OnionApp.Domain.Core;
using OnionApp.Services.Interfaces;

namespace OnionApp.Infrastructure.Business
{
    public class CacheOrder : IOrder
    {
        public void MakeOrder(Book book) 
        {
            // код покупки книги при оплате наличностью
        }
    }
}
