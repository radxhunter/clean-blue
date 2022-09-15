using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Products.Commands.AddProduct;
using CleanArchitecture.Application.TodoItems.Commands.CreateTodoItem;
using CleanArchitecture.Application.TodoLists.Commands.CreateTodoList;
using CleanArchitecture.Domain.Entities;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace CleanArchitecture.Application.IntegrationTests.Products.Commands;

using static Testing;

public class AddProductCommandTests : BaseTestFixture
{
    //[Test]
    //public async Task ShouldCreateProduct()
    //{
    //    var userId = await RunAsDefaultUserAsync();

    //    var command = new AddProductCommand
    //    {
    //        Name = "New Product",
    //        Description = It.IsAny<string>(),
    //        Number = It.IsAny<int>(),
    //        Price = It.IsAny<decimal>(),
    //        Quantity = It.IsAny<int>(),
    //    };

    //    var productId = await SendAsync(command);

    //    var item = await FindAsync<Product>(productId);

    //    item.Should().NotBeNull();
    //    item!.Id.Should().Be(productId);
    //    item.Name.Should().Be(command.Name);
    //    item.Description.Should().Be(command.Description);
    //    item.Number.Should().Be(command.Number);
    //    item.Price.Should().Be(command.Price);
    //    item.Quantity.Should().Be(command.Quantity);
    //    item.CreatedBy.Should().Be(userId);
    //    item.Created.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    //    item.LastModifiedBy.Should().Be(userId);
    //    item.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
