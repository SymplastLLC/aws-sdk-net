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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the PutApplicationAssignmentConfiguration operation.
    /// Configure how users gain access to an application. If <code>AssignmentsRequired</code>
    /// is <code>true</code> (default value), users don’t have access to the application unless
    /// an assignment is created using the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment
    /// API</a>. If <code>false</code>, all users have access to the application. If an assignment
    /// is created using <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment</a>.,
    /// the user retains access if <code>AssignmentsRequired</code> is set to <code>true</code>.
    /// </summary>
    public partial class PutApplicationAssignmentConfigurationRequest : AmazonSSOAdminRequest
    {
        private string _applicationArn;
        private bool? _assignmentRequired;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application. For more information about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssignmentRequired. 
        /// <para>
        /// If <code>AssignmentsRequired</code> is <code>true</code> (default value), users don’t
        /// have access to the application unless an assignment is created using the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment
        /// API</a>. If <code>false</code>, all users have access to the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AssignmentRequired
        {
            get { return this._assignmentRequired.GetValueOrDefault(); }
            set { this._assignmentRequired = value; }
        }

        // Check to see if AssignmentRequired property is set
        internal bool IsSetAssignmentRequired()
        {
            return this._assignmentRequired.HasValue; 
        }

    }
}