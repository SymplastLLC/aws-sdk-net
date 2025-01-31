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
    /// A set of parameters that configure the behavior of the enabled control. A key/value
    /// pair, where <code>Key</code> is of type <code>String</code> and <code>Value</code>
    /// is of type <code>Document</code>.
    /// </summary>
    public partial class EnabledControlParameter
    {
        private string _key;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of a key/value pair. It is of type <code>string</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a key/value pair. It can be of type <code>array</code> <code>string</code>,
        /// <code>number</code>, <code>object</code>, or <code>boolean</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}