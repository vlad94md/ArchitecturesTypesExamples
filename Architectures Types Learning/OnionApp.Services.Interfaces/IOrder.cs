using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;

namespace OnionApp.Services.Interfaces
{
    public interface IOrder
    {
        void MakeOrder(Book book);
    }
}
