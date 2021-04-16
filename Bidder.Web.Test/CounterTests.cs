using Bidder.Web.Pages;
using Xunit;
using Bunit;

namespace Bidder.Web.Test
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void CounterMarkupShouldNotBeEmpty()
        {
            // Act
            var cut = RenderComponent<Counter>();
            cut.Find("button").Click();

            // Assert
            cut.Find("p").MarkupMatches("<p>Current count: 1</p>");
        }
    }
}