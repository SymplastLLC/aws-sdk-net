/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains details for one of the table optimizers returned by the <code>BatchGetTableOptimizer</code>
    /// operation.
    /// </summary>
    public partial class BatchTableOptimizer
    {
        private string _catalogId;
        private string _databaseName;
        private string _tableName;
        private TableOptimizer _tableOptimizer;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The Catalog ID of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database in the catalog in which the table resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableOptimizer. 
        /// <para>
        /// A <code>TableOptimizer</code> object that contains details on the configuration and
        /// last run of a table optimzer.
        /// </para>
        /// </summary>
        public TableOptimizer TableOptimizer
        {
            get { return this._tableOptimizer; }
            set { this._tableOptimizer = value; }
        }

        // Check to see if TableOptimizer property is set
        internal bool IsSetTableOptimizer()
        {
            return this._tableOptimizer != null;
        }

    }
}