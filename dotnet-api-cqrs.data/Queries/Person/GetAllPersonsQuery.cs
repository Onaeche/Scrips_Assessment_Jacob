using System.Collections.Generic;
using System.Data;
using dotnet_api_cqrs.contracts.data;
using D = dotnet_api_cqrs.contracts.dto;

namespace dotnet_api_cqrs.data.Queries.Person
{
	public class GetAllPersonsQuery : IQuery<IEnumerable<D.Person>>
	{
		public string Sql { get; set; }

		public GetAllPersonsQuery()
		{
			Sql = @$"
SELECT				BookID,
					Title,
					CopyRightYear,
					AuthorID
FROM				dbo.Books
ORDER BY			Title";
		}

		/// <summary>
		/// This is an example. Since I don't have a real database setup, I'm just returning hard coded data.
		/// However, I have the actual code commented out so you can see how it works if there really were a database.
		/// </summary>
		public IEnumerable<D.Person> Execute(IDbContext context, IDbTransaction transaction = null)
		{
			// return context.Query<D.Book>(Sql, transaction: transaction);

			return TestData.Persons;
		}
	}
}
