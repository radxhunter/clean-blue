using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Invoice
{
    public int Id { get; set; }
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
