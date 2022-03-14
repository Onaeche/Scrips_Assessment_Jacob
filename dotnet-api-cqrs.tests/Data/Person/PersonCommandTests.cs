using System.Linq;
using dotnet_api_cqrs.data;
using dotnet_api_cqrs.data.Commands.Person;
using Xunit;
using D = dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.tests.Data.Person
{
	public class PersonCommandTests : TestBase
	{
		private readonly D.Person _testPerson;

		public PersonCommandTests() : base(true)
		{
			_testPerson = TestData.Persons.First();
		}

		[Fact]
		public void UpdatePersonCommandTest()
		{
			var command = new UpdatePersonCommand(_testPerson);
			var results = command.Execute(TestDbContext);

			Assert.True(results > 0);
		}

	}
}
