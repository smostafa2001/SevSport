using Microsoft.Data.SqlClient;
using SevSport.DAL.Entities.SportClothingAggregate;
using System.Data;

namespace SevSport.DAL.DataAccessObjects.SportClothingAggregate;
public class CategoryDAO(SqlConnection connection) : BaseDAO<Category>(connection)
{
    public override Category Save(Category t)
    {
        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "INSERT INTO dbo.Categories ";
        connection.Open();
        return new();
    }

    public override Category Get(long id) => throw new NotImplementedException();
    public override List<Category> GetAll() => throw new NotImplementedException();
    public override Category Update(Category t) => throw new NotImplementedException();
    public override Category Delete(Category t) => throw new NotImplementedException();
    public override int Count() => throw new NotImplementedException();
}