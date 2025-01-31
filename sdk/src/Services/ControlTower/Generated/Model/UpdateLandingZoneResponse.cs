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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// This is the response object from the UpdateLandingZone operation.
    /// </summary>
    public partial class UpdateLandingZoneResponse : AmazonWebServiceResponse
    {
        private string _operationIdentifier;

        /// <summary>
        /// Gets and sets the property OperationIdentifier. 
        /// <para>
        /// A unique identifier assigned to a <code>UpdateLandingZone</code> operation. You can
        /// use this identifier as an input of <code>GetLandingZoneOperation</code> to check the
        /// operation's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string OperationIdentifier
        {
            get { return this._operationIdentifier; }
            set { this._operationIdentifier = value; }
        }

        // Check to see if OperationIdentifier property is set
        internal bool IsSetOperationIdentifier()
        {
            return this._operationIdentifier != null;
        }

    }
}