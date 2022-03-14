using System.Collections.Generic;
using dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.contracts.services
{
	public interface IPersonService
	{
		IEnumerable<Person> GetPersonByEmail(string email);
		UpdatePerson UpdatePerson(Person person);
	}
}
