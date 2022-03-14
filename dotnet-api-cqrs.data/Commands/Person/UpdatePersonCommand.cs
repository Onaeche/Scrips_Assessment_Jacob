using System.Data;
using dotnet_api_cqrs.contracts.data;
using D = dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.data.Commands.Person
{
	public class UpdatePersonCommand : ICommand
	{
		private readonly D.Person _person;

		public string Sql { get; set; }

		public UpdatePersonCommand(D.Person person)
		{
			_person = person;

			Sql = $@"
update [dbo].[HumanNames] set Family =@family, Given =@Given where personId =@PersonId update[dbo].[ContactPoints] set[Value] = @Phone where personId = @PersonId and[System] = 'Phone';";

        }

		
		public int Execute(IDbContext context, IDbTransaction transaction = null)
		{
    //        var param = new
    //        {
				//PersonId = _person.PersonId,
				//Family = _person.Family,
				//Given = _person.Given,
				//Phone = _person.Phone,
    //        };

    //        return context.UpdatePerson(Sql, param, transaction: transaction);

            return 1;
		}
	}
}
