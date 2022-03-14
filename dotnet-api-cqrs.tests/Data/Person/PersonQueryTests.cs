using dotnet_api_cqrs.data.Queries.Person;
using Xunit;

namespace dotnet_api_cqrs.tests.Data.Person
{
	public class PersonQueryTests : TestBase
	{
		[Fact]
		public void GetAllPersonsTest()
		{
			var query = new GetAllPersonsQuery();
			var results = query.Execute(TestDbContext);

			Assert.NotEmpty(results);
		}


	}
}
