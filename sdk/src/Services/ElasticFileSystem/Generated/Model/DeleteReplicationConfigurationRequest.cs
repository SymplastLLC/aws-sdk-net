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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReplicationConfiguration operation.
    /// Deletes a replication configuration. Deleting a replication configuration ends the
    /// replication process. After a replication configuration is deleted, the destination
    /// file system becomes <code>Writeable</code> and its replication overwrite protection
    /// is re-enabled. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/delete-replications.html">Delete
    /// a replication configuration</a>.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:DeleteReplicationConfiguration</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DeleteReplicationConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private string _sourceFileSystemId;

        /// <summary>
        /// Gets and sets the property SourceFileSystemId. 
        /// <para>
        /// The ID of the source file system in the replication configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string SourceFileSystemId
        {
            get { return this._sourceFileSystemId; }
            set { this._sourceFileSystemId = value; }
        }

        // Check to see if SourceFileSystemId property is set
        internal bool IsSetSourceFileSystemId()
        {
            return this._sourceFileSystemId != null;
        }

    }
}