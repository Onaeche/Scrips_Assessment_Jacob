using System.Collections.Generic;
using dotnet_api_cqrs.contracts.dto;
using dotnet_api_cqrs.contracts.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_api_cqrs.api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PersonController : ControllerBase
	{
		private readonly ILogger<PersonController> _logger;
		private readonly IPersonService _personService;

		public PersonController(ILogger<PersonController> logger, IPersonService personService)
		{
			_logger = logger;
			_personService = personService;
		}


		[HttpGet("GetPersonByEmail")]
		public IEnumerable<Person> GetPersonByEmail(string email)
		{
			return _personService.GetPersonByEmail(email);
		}

		[HttpPost("UpdatePerson")]
		public UpdatePerson UpdatePerson(Person person)
		{
			return _personService.UpdatePerson(person);
		}

		
	}
}
