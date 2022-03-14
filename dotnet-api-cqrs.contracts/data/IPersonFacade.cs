using System;
using System.Collections.Generic;
using System.Data;
using dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.contracts.data
{
	public interface IPersonFacade
	{
		
		Func<IDbContext, IDbTransaction, IEnumerable<Person>> GetPersonByEmail(string Email);
		Func<IDbContext, IDbTransaction, int> UpdatePerson(Person book);
	}
}
