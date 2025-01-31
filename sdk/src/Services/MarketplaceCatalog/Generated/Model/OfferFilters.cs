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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A filter for offers entity.
    /// </summary>
    public partial class OfferFilters
    {
        private OfferAvailabilityEndDateFilter _availabilityEndDate;
        private OfferBuyerAccountsFilter _buyerAccounts;
        private OfferEntityIdFilter _entityId;
        private OfferLastModifiedDateFilter _lastModifiedDate;
        private OfferNameFilter _name;
        private OfferProductIdFilter _productId;
        private OfferReleaseDateFilter _releaseDate;
        private OfferStateFilter _state;
        private OfferTargetingFilter _targeting;

        /// <summary>
        /// Gets and sets the property AvailabilityEndDate. 
        /// <para>
        /// Allows filtering on the <code>AvailabilityEndDate</code> of an offer.
        /// </para>
        /// </summary>
        public OfferAvailabilityEndDateFilter AvailabilityEndDate
        {
            get { return this._availabilityEndDate; }
            set { this._availabilityEndDate = value; }
        }

        // Check to see if AvailabilityEndDate property is set
        internal bool IsSetAvailabilityEndDate()
        {
            return this._availabilityEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property BuyerAccounts. 
        /// <para>
        /// Allows filtering on the <code>BuyerAccounts</code> of an offer.
        /// </para>
        /// </summary>
        public OfferBuyerAccountsFilter BuyerAccounts
        {
            get { return this._buyerAccounts; }
            set { this._buyerAccounts = value; }
        }

        // Check to see if BuyerAccounts property is set
        internal bool IsSetBuyerAccounts()
        {
            return this._buyerAccounts != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Allows filtering on <code>EntityId</code> of an offer.
        /// </para>
        /// </summary>
        public OfferEntityIdFilter EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Allows filtering on the <code>LastModifiedDate</code> of an offer.
        /// </para>
        /// </summary>
        public OfferLastModifiedDateFilter LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Allows filtering on the <code>Name</code> of an offer.
        /// </para>
        /// </summary>
        public OfferNameFilter Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// Allows filtering on the <code>ProductId</code> of an offer.
        /// </para>
        /// </summary>
        public OfferProductIdFilter ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// Allows filtering on the <code>ReleaseDate</code> of an offer.
        /// </para>
        /// </summary>
        public OfferReleaseDateFilter ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Allows filtering on the <code>State</code> of an offer.
        /// </para>
        /// </summary>
        public OfferStateFilter State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Targeting. 
        /// <para>
        /// Allows filtering on the <code>Targeting</code> of an offer.
        /// </para>
        /// </summary>
        public OfferTargetingFilter Targeting
        {
            get { return this._targeting; }
            set { this._targeting = value; }
        }

        // Check to see if Targeting property is set
        internal bool IsSetTargeting()
        {
            return this._targeting != null;
        }

    }
}