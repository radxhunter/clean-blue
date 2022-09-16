using CleanArchitecture.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.TodoItems.EventHandlers;

public class ProductAddedEventHandler : INotificationHandler<ProductCreatedEvent>
{
    private readonly ILogger<ProductAddedEventHandler> _logger;

    public ProductAddedEventHandler(ILogger<ProductAddedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CleanArchitecture Domain Event: {DomainEvent}", notification.GetType().Name);
        return Task.CompletedTask;
    }
}
