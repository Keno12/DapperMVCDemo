using DapperMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperMVCDemo.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetByID(string id);

        Task<List<Order>> GetOrderList(DateTime dateOfBirth);
    }
}
