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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the CreateTaskSet operation.
    /// </summary>
    public partial class CreateTaskSetResponse : AmazonWebServiceResponse
    {
        private TaskSet _taskSet;

        /// <summary>
        /// Gets and sets the property TaskSet. 
        /// <para>
        /// Information about a set of Amazon ECS tasks in either an AWS CodeDeploy or an <code>EXTERNAL</code>
        /// deployment. A task set includes details such as the desired number of tasks, how many
        /// tasks are running, and whether the task set serves production traffic.
        /// </para>
        /// </summary>
        public TaskSet TaskSet
        {
            get { return this._taskSet; }
            set { this._taskSet = value; }
        }

        // Check to see if TaskSet property is set
        internal bool IsSetTaskSet()
        {
            return this._taskSet != null;
        }

    }
}