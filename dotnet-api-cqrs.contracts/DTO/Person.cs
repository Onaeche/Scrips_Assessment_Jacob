namespace dotnet_api_cqrs.contracts.dto
{

	public class Person
	{
		public string PersonId { get; set; }
		public string name { get; set; }
		public string Family { get; set; }
		public string Given { get; set; }
		public string Phone { get; set; }
	}

	public class UpdatePerson
	{
		public string PersonId { get; set; }
		public string message { get; set; }
		public string Family { get; set; }
		public string Given { get; set; }
		public string Phone { get; set; }
	}


}
