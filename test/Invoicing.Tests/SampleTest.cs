using FluentAssertions;
using Xunit;

namespace Invoicing.Tests;

public class InvoiceTest
{
    [Fact]
    public void IfExecutesTest()
    {
        string variable = "middle";
        variable.Should().NotBe(string.Empty);
    }
}