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
    /// The backup policy for the file system used to create automatic daily backups. If status
    /// has a value of <code>ENABLED</code>, the file system is being automatically backed
    /// up. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/awsbackup.html#automatic-backups">Automatic
    /// backups</a>.
    /// </summary>
    public partial class BackupPolicy
    {
        private Status _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the status of the file system's backup policy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>ENABLED</code> </b> – EFS is automatically backing up the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>ENABLING</code> </b> – EFS is turning on automatic backups for the file
        /// system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DISABLED</code> </b> – Automatic back ups are turned off for the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DISABLING</code> </b> – EFS is turning off automatic backups for the file
        /// system.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}