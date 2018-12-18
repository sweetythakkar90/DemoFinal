using System.Data;

namespace Hourly.Interface
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
