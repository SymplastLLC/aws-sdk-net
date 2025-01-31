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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteFastReset operation.
    /// The fast reset REST API lets you reset a Neptune graph quicky and easily, removing
    /// all of its data.
    /// 
    ///  
    /// <para>
    /// Neptune fast reset is a two-step process. First you call <code>ExecuteFastReset</code>
    /// with <code>action</code> set to <code>initiateDatabaseReset</code>. This returns a
    /// UUID token which you then include when calling <code>ExecuteFastReset</code> again
    /// with <code>action</code> set to <code>performDatabaseReset</code>. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-fast-reset.html">Empty
    /// an Amazon Neptune DB cluster using the fast reset API</a>.
    /// </para>
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#resetdatabase">neptune-db:ResetDatabase</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    public partial class ExecuteFastResetRequest : AmazonNeptunedataRequest
    {
        private Action _action;
        private string _token;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The fast reset action. One of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>initiateDatabaseReset</code> </b>   –   This action generates a unique
        /// token needed to actually perform the fast reset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>performDatabaseReset</code> </b>   –   This action uses the token generated
        /// by the <code>initiateDatabaseReset</code> action to actually perform the fast reset.
        /// </para>
        ///   </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The fast-reset token to initiate the reset.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}