using System;
using System.Data;

namespace Hourly.Domain.Database
{
    public class DatabaseAssistant : IDisposable, IDatabaseAssistant
    {
        private IDbConnection _db;
        private string _connectionString;
        private IDbTransaction _t;
        private bool _isDisposed;

        /// <summary>
        /// Return database connection held by this DatabaseAssistant.
        /// </summary>
        private IDbConnection db
        {
            get
            {
                return _db;
            }
        }

        /// <summary>
        /// Return connection string for the associated database connection.
        /// </summary>
        public string ConnectionString
        {
            get { return _connectionString; }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
           
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                CloseIDbConnection();
                
            }

            _connectionString = null;
            _isDisposed = true;
        }
        private void CloseIDbConnection()
        {
            // Not to dispose connection until it's been committed
            if (_t == null || _t.Connection != _db)
            {
                _db.Close();
                _db.Dispose();
            }
        }    
    }
}
