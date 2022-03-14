using System.Collections.Generic;
using dotnet_api_cqrs.contracts.data;
using dotnet_api_cqrs.contracts.dto;
using dotnet_api_cqrs.contracts.services;

namespace dotnet_api_cqrs.services
{
	public class PersonService : Service, IPersonService
	{
		private readonly IPersonFacade _personFacade;

		public PersonService(IDbContext context, IPersonFacade personFacade) : base(context)
		{
			_personFacade = personFacade;
		}

		
		public IEnumerable<Person> GetPersonByEmail(string email)
		{
			return _personFacade.GetPersonByEmail(email)(Context, null);
		}

		public UpdatePerson UpdatePerson(Person person)
		{
			UpdatePerson updatePerson = new UpdatePerson();

			updatePerson.Family = person.Family;
			updatePerson.Given = person.Given;
			updatePerson.Phone = person.Phone;
			updatePerson.message = "Updated Successfully";

			return updatePerson;
		}

		

	}
}
