using System.Collections.Generic;
using dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.data
{
	public static class TestData
	{
		
		public static List<Person> Persons = new() {
			new Person { name = "Jacob", Given = "Naeche", Family = "Olua", Phone = "090893899" },
			new Person { name = "Jacob_2", Given = "Naeche_2", Family = "Olua_2", Phone = "08078488" },
			new Person { name = "Jacob_3", Given = "Naeche_3", Family = "Olua_3", Phone = "099988922" },
			
		};
	}
}
