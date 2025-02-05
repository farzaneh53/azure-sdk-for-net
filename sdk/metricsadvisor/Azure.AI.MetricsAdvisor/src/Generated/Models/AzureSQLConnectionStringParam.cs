// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureSQLConnectionStringParam. </summary>
    internal partial class AzureSQLConnectionStringParam
    {
        /// <summary> Initializes a new instance of AzureSQLConnectionStringParam. </summary>
        /// <param name="connectionString"> The connection string to access the Azure SQL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public AzureSQLConnectionStringParam(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
        }

        /// <summary> The connection string to access the Azure SQL. </summary>
        public string ConnectionString { get; set; }
    }
}
