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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKnowledgeBase operation.
    /// Update an existing knowledge base
    /// </summary>
    public partial class UpdateKnowledgeBaseRequest : AmazonBedrockAgentRequest
    {
        private string _description;
        private KnowledgeBaseConfiguration _knowledgeBaseConfiguration;
        private string _knowledgeBaseId;
        private string _name;
        private string _roleArn;
        private StorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration
        {
            get { return this._knowledgeBaseConfiguration; }
            set { this._knowledgeBaseConfiguration = value; }
        }

        // Check to see if KnowledgeBaseConfiguration property is set
        internal bool IsSetKnowledgeBaseConfiguration()
        {
            return this._knowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageConfiguration StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

    }
}