using System.Collections.Generic;
using System.Data;
using System.Linq;
using dotnet_api_cqrs.contracts.data;
using D = dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.data.Queries.Person
{
	public class GetPersonForEmailQuery : IQuery<IEnumerable<D.Person>>
	{
		private readonly string _email;

		public string Sql { get; set; }

		public GetPersonForEmailQuery(string email)
		{
			_email = email;

			Sql = $@"
select b.[Name],b.Family,b.Given, a.id  into #d from [dbo].[Persons] a left outer join[dbo].[HumanNames] b on a.ID = b.PersonId select* into #a from [dbo].[ContactPoints] where System ='Email'select* into #b from [dbo].[ContactPoints] where System ='Phone'select a.id, a.value as Email, b.Value as Phone,a.PersonId into #c from #a a join #b b on a.PersonId = b.PersonId where a.Value =@Email select name, family, Given, Email, Phone from #d a join #c b on a.Id = b.PersonId drop table #a,#b,#c,#d ;";

//			Sql = $@"
//SELECT				BookID,
//					Title,
//					CopyRightYear,
//					AuthorID
//FROM				dbo.Books
//WHERE				AuthorID = @AuthorID
//ORDER BY			CopyRightYear, Title;";
		}

		/// <summary>
		/// This is an example. Since I don't have a real database setup, I'm just returning hard coded data.
		/// However, I have the actual code commented out so you can see how it works if there really were a database.
		/// </summary>
		public IEnumerable<D.Person> Execute(IDbContext context, IDbTransaction transaction = null)
		{
            var param = new
            {
				Email = _email
            };

            return context.Query<D.Person>(Sql, param, transaction: transaction);

           // return TestData.Persons.Where(b => b.PersonId == _email);
		}
	}
}
