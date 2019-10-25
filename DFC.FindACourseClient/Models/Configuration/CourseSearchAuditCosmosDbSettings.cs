﻿using System;

namespace DFC.FindACourseClient.Models.Configuration
{
    /// <summary>
    /// Used to supply Cosmos DB connection values from app settings.
    /// </summary>
    public class CourseSearchAuditCosmosDbSettings
    {
        /// <summary>
        /// Gets or sets  - Cosmos DB - Access Key.
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or sets  - Cosmos DB - Endpoint Url.
        /// </summary>
        public Uri EndpointUrl { get; set; }

        /// <summary>
        /// Gets or sets  - Cosmos DB - Database Id.
        /// </summary>
        public string DatabaseId { get; set; }

        /// <summary>
        /// Gets or sets - Cosmos DB - Collection Id.
        /// </summary>
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or sets  - Cosmos DB - Partition Key.
        /// </summary>
        public string PartitionKey { get; set; }
    }
}