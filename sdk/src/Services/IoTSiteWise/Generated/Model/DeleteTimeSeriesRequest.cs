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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTimeSeries operation.
    /// Deletes a time series (data stream). If you delete a time series that's associated
    /// with an asset property, the asset property still exists, but the time series will
    /// no longer be associated with this asset property.
    /// 
    ///  
    /// <para>
    /// To identify a time series, do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the time series isn't associated with an asset property, specify the <code>alias</code>
    /// of the time series.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the time series is associated with an asset property, specify one of the following:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>alias</code> of the time series.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>assetId</code> and <code>propertyId</code> that identifies the asset property.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class DeleteTimeSeriesRequest : AmazonIoTSiteWiseRequest
    {
        private string _alias;
        private string _assetId;
        private string _clientToken;
        private string _propertyId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias that identifies the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset in which the asset property was created. This can be either the
        /// actual ID in UUID format, or else <code>externalId:</code> followed by the external
        /// ID, if it has one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=139)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property. This can be either the actual ID in UUID format, or
        /// else <code>externalId:</code> followed by the external ID, if it has one. For more
        /// information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=139)]
        public string PropertyId
        {
            get { return this._propertyId; }
            set { this._propertyId = value; }
        }

        // Check to see if PropertyId property is set
        internal bool IsSetPropertyId()
        {
            return this._propertyId != null;
        }

    }
}