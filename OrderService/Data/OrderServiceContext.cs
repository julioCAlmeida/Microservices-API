using Microsoft.EntityFrameworkCore;

namespace OrderService.Data;

public class OrderServiceContext : DbContext
{
    public OrderServiceContext(DbContextOptions<OrderServiceContext> options) : base(options)
    {
    }

    public DbSet<BusinessObjects.Order> Orders { get; set; }
}
