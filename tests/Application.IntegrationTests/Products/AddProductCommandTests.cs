using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Products.Commands.AddProduct;
using CleanArchitecture.Domain.Entities;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace CleanArchitecture.Application.IntegrationTests.Products;

using static Testing;
public class AddProductCommandTests
{
    [Test]
    public async Task ShouldCreateProduct()
    {
        var userId = await RunAsDefaultUserAsync();

        var command = new AddProductCommand
        {
            Name = "New Product",
            Description = It.IsAny<string>(),
            Number = It.IsAny<int>(),
            Price= It.IsAny<decimal>(),
            Quantity = It.IsAny<int>(),
        };

        var productId = await SendAsync(command);

        var product = await FindAsync<Product>(productId);

        product.Should().NotBeNull();
        product.Name.Should().Be(command.Name);
        product.Description.Should().Be(command.Description);
        product.Number.Should().Be(command.Number);
        product.Price.Should().Be(command.Price);
        product.Quantity.Should().Be(command.Quantity);
        product.CreatedBy.Should().Be(userId);
        product.Created.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
        product.LastModifiedBy.Should().Be(userId);
        product.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
