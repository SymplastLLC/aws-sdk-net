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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the ListPodIdentityAssociations operation.
    /// List the EKS Pod Identity associations in a cluster. You can filter the list by the
    /// namespace that the association is in or the service account that the association uses.
    /// </summary>
    public partial class ListPodIdentityAssociationsRequest : AmazonEKSRequest
    {
        private string _clusterName;
        private int? _maxResults;
        private string _awsNamespace;
        private string _nextToken;
        private string _serviceAccount;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the associations are in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of EKS Pod Identity association results returned by <code>ListPodIdentityAssociations</code>
        /// in paginated output. When you use this parameter, <code>ListPodIdentityAssociations</code>
        /// returns only <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. You can see the remaining results of the initial request by sending
        /// another <code>ListPodIdentityAssociations</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If you don't use this parameter, <code>ListPodIdentityAssociations</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster that the associations are
        /// in.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListUpdates</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is used only to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The name of the Kubernetes service account that the associations use.
        /// </para>
        /// </summary>
        public string ServiceAccount
        {
            get { return this._serviceAccount; }
            set { this._serviceAccount = value; }
        }

        // Check to see if ServiceAccount property is set
        internal bool IsSetServiceAccount()
        {
            return this._serviceAccount != null;
        }

    }
}