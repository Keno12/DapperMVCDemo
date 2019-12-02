using Dapper;
using DapperMVCDemo.Models;
using DapperMVCDemo.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMVCDemo.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _config;

        public OrderRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("ConnectionStrings"));
            }
        }

        public async Task<Order> GetByID(string id)
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT * FROM Order WHERE OrderId = @OrderId";
                conn.Open();
                var result = await conn.QueryAsync<Order>(sQuery, new { OrderId = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<List<Order>> GetOrderList(DateTime dateOfBirth)
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Order WHERE DateOfBirth = @DateOfBirth";
                conn.Open();
                var result = await conn.QueryAsync<Order>(sQuery, new { DateOfBirth = dateOfBirth });
                return result.ToList();
            }
        }
    }
}
