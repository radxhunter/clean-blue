using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Events;
using MediatR;

namespace CleanArchitecture.Application.Invoices.Commands.CreateInvoice;
public class CreateInvoiceCommand : IRequest<int>
{
    public string? NameOfCompanySeller { get; set; }
    public string? NameOfCompanyBuyer { get; set; }
    public string? NIP { get; set; }
    public bool PaymentByBankTransfer { get; set; }
    public string? InvoiceNumber { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime SaleDate { get; set; }
    public DateTime PaymentDeadline { get; set; }
}

public class CreateTodoItemCommandHandler : IRequestHandler<CreateInvoiceCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
    {
        var entity = new Invoice()
        {
            NameOfCompanySeller = request.NameOfCompanySeller,
            NameOfCompanyBuyer = request.NameOfCompanyBuyer,
            NIP = request.NIP,
            PaymentByBankTransfer = request.PaymentByBankTransfer,
            InvoiceNumber = request.InvoiceNumber,
            Amount = request.Amount
        };

        entity.AddDomainEvent(new InvoiceCreatedEvent(entity));

        _context.Invoices.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}