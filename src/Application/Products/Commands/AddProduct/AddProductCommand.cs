using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Events;

namespace CleanArchitecture.Application.Products.Commands.AddProduct;
public record AddProductCommand : IRequest<int>
{
    public string Name { get; set; }
    public int? Number { get; set; }
    public int? Quantity { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
}

public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
{
    private readonly IApplicationDbContext _context;

    public AddProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product()
        {
            Description = request.Description,
            Price = request.Price,
            Quantity = request.Quantity,
            Name = request.Name,
            Number = request.Number,
        };

        entity.AddDomainEvent(new ProductCreatedEvent(entity));

        _context.Products.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
