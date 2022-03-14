using dotnet_api_cqrs.contracts.data;
using dotnet_api_cqrs.data;
using dotnet_api_cqrs.services;
using Moq;
using Xunit;

namespace dotnet_api_cqrs.tests.Services
{
	public class PersonServicesTests : TestBase
	{
		[Fact]
		public void GetAllTest()
		{
			//var mockFacade = new Mock<IPersonFacade>();
			//mockFacade.Setup(repo => repo.GetPersonByEmail())
			//	.Returns((context, transaction) => {
			//		return TestData.Persons;
			//	});

			//var personService = new PersonService(TestDbContext, mockFacade.Object);

			//Assert.NotEmpty(personService.UpdatePerson());
		}
	}
}
