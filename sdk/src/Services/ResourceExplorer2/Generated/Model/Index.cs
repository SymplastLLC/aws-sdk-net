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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// An index is the data store used by Amazon Web Services Resource Explorer to hold information
    /// about your Amazon Web Services resources that the service discovers. Creating an index
    /// in an Amazon Web Services Region turns on Resource Explorer and lets it discover your
    /// resources.
    /// 
    ///  
    /// <para>
    /// By default, an index is <i>local</i>, meaning that it contains information about resources
    /// in only the same Region as the index. However, you can promote the index of one Region
    /// in the account by calling <a>UpdateIndexType</a> to convert it into an aggregator
    /// index. The aggregator index receives a replicated copy of the index information from
    /// all other Regions where Resource Explorer is turned on. This allows search operations
    /// in that Region to return results from all Regions in the account.
    /// </para>
    /// </summary>
    public partial class Index
    {
        private string _arn;
        private string _region;
        private IndexType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the index.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the index exists.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of index. It can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LOCAL</code> – The index contains information about resources from only the
        /// same Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AGGREGATOR</code> – Resource Explorer replicates copies of the indexed information
        /// about resources in all other Amazon Web Services Regions to the aggregator index.
        /// This lets search results in the Region with the aggregator index to include resources
        /// from all Regions in the account where Resource Explorer is turned on.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IndexType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}