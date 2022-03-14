using System;
using System.Collections.Generic;
using System.Data;
using dotnet_api_cqrs.contracts.data;
using dotnet_api_cqrs.contracts.dto;
using dotnet_api_cqrs.data.Commands.Person;
using dotnet_api_cqrs.data.Queries.Person;

namespace dotnet_api_cqrs.data
{
	public class PersonFacade : Facade, IPersonFacade
	{
		

		public Func<IDbContext, IDbTransaction, IEnumerable<Person>> GetPersonByEmail(string email)
		{
			return Prepare(new GetPersonForEmailQuery(email));
		}

		public Func<IDbContext, IDbTransaction, int> UpdatePerson(Person person)
		{
			return Prepare<int>(new UpdatePersonCommand(person));
		}

		
	}
}
