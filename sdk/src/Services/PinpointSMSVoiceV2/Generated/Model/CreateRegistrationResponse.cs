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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the CreateRegistration operation.
    /// </summary>
    public partial class CreateRegistrationResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _additionalAttributes = new Dictionary<string, string>();
        private DateTime? _createdTimestamp;
        private long? _currentVersionNumber;
        private string _registrationArn;
        private string _registrationId;
        private RegistrationStatus _registrationStatus;
        private string _registrationType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// Metadata about a given registration which is specific to that registration type.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null && this._additionalAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the registration was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentVersionNumber. 
        /// <para>
        /// The current version number of the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100000)]
        public long CurrentVersionNumber
        {
            get { return this._currentVersionNumber.GetValueOrDefault(); }
            set { this._currentVersionNumber = value; }
        }

        // Check to see if CurrentVersionNumber property is set
        internal bool IsSetCurrentVersionNumber()
        {
            return this._currentVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationArn
        {
            get { return this._registrationArn; }
            set { this._registrationArn = value; }
        }

        // Check to see if RegistrationArn property is set
        internal bool IsSetRegistrationArn()
        {
            return this._registrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The status of the registration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATED</code>: Your registration is created but not submitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUBMITTED</code>: Your registration has been submitted and is awaiting review.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REVIEWING</code>: Your registration has been accepted and is being reviewed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PROVISIONING</code>: Your registration has been approved and your origination
        /// identity is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETE</code>: Your registration has been approved and and your origination
        /// identity has been created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REQUIRES_UPDATES</code>: You must fix your registration and resubmit it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CLOSED</code>: The phone number or sender ID has been deleted and you must
        /// also delete the registration for the number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code>: The registration has been deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationStatus RegistrationStatus
        {
            get { return this._registrationStatus; }
            set { this._registrationStatus = value; }
        }

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this._registrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        /// The type of registration form to create. The list of <b>RegistrationTypes</b> can
        /// be found using the <a>DescribeRegistrationTypeDefinitions</a> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RegistrationType
        {
            get { return this._registrationType; }
            set { this._registrationType = value; }
        }

        // Check to see if RegistrationType property is set
        internal bool IsSetRegistrationType()
        {
            return this._registrationType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) to associate with the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}