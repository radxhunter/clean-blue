using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
<<<<<<< HEAD
    DbSet<Product> Products { get; }
=======
    DbSet<Invoice> Invoices { get; }

>>>>>>> origin/main

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
