using Microsoft.EntityFrameworkCore;
using OrderService.Application.Contracts;
using OrderServise.Domain.Entities;
using OrderServise.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServise.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepositoryAsync<Order>, IOrderRepository
    {
        public OrderRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<Order> GetOrderForUser(string UserId)
        {
            var data= await _dbContext.Orders.Include(x=>x.Items).FirstOrDefaultAsync(order=>order.UserId == UserId);
            return data;
        }

        public async Task<Order> GetOrderHistoryAsync(int Id)
        {
           // _dbContext.Orders.TemporalAsOf=>return history of special Time
            //we can recicevd history of changes in data base
         var res= await _dbContext.Orders.TemporalAll().Where(p=>p.Id == Id)
                .OrderBy(p => EF.Property<DateTime>(p, "PeriodEnd")).Select(p=>new
                {
                    start=EF.Property<DateTime>(p,"PeriodEnd")
                }).ToListAsync();
            return null;
        }
        
        //public Task GetOrderByUserId(string UserId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
