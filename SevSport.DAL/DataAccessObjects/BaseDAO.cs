using Microsoft.Data.SqlClient;

namespace SevSport.DAL.DataAccessObjects;
public abstract class BaseDAO<T>(SqlConnection connection)
{
    protected readonly SqlConnection connection = connection;

    public abstract T Save(T t);
    public abstract List<T> GetAll();
    public abstract T Get(long id);
    public abstract T Update(T t);
    public abstract T Delete(T t);
    public abstract int Count();
}