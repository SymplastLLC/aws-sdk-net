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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the GetPartnership operation.
    /// Retrieves the details for a partnership, based on the partner and profile IDs specified.
    /// Partnerships link trading partners with your profile and a specific transformer, so
    /// that the EDI (electronic data interchange) documents that they upload to Amazon S3
    /// can be processed according to their specifications.
    /// </summary>
    public partial class GetPartnershipRequest : AmazonB2biRequest
    {
        private string _partnershipId;

        /// <summary>
        /// Gets and sets the property PartnershipId. 
        /// <para>
        /// Specifies the unique, system-generated identifier for a partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PartnershipId
        {
            get { return this._partnershipId; }
            set { this._partnershipId = value; }
        }

        // Check to see if PartnershipId property is set
        internal bool IsSetPartnershipId()
        {
            return this._partnershipId != null;
        }

    }
}