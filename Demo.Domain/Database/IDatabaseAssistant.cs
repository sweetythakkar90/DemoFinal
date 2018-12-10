using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Demo.Domain.Database
{
    public interface IDatabaseAssistant
    {
        /// <summary>
        /// Return connection string for the associated database connection.
        /// </summary>
        string ConnectionString { get; }       
    }
}
