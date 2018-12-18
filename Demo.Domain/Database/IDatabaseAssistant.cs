namespace Hourly.Domain.Database
{
    public interface IDatabaseAssistant
    {
        /// <summary>
        /// Return connection string for the associated database connection.
        /// </summary>
        string ConnectionString { get; }       
    }
}
