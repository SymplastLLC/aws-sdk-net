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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the GetRestoreTestingPlan operation.
    /// Returns <code>RestoreTestingPlan</code> details for the specified <code>RestoreTestingPlanName</code>.
    /// The details are the body of a restore testing plan in JSON format, in addition to
    /// plan metadata.
    /// </summary>
    public partial class GetRestoreTestingPlanRequest : AmazonBackupRequest
    {
        private string _restoreTestingPlanName;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// Required unique name of the restore testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingPlanName
        {
            get { return this._restoreTestingPlanName; }
            set { this._restoreTestingPlanName = value; }
        }

        // Check to see if RestoreTestingPlanName property is set
        internal bool IsSetRestoreTestingPlanName()
        {
            return this._restoreTestingPlanName != null;
        }

    }
}