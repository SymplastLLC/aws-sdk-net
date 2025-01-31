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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.B2bi.Model;
using Amazon.B2bi.Model.Internal.MarshallTransformations;
using Amazon.B2bi.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.B2bi
{
    /// <summary>
    /// Implementation for accessing B2bi
    ///
    /// This is the <i>Amazon Web Services B2B Data Interchange API Reference</i>. It provides
    /// descriptions, API request parameters, and the XML response for each of the B2BI API
    /// actions.
    /// 
    ///  
    /// <para>
    /// B2BI enables automated exchange of EDI (electronic data interchange) based business-critical
    /// transactions at cloud scale, with elasticity and pay-as-you-go pricing. Businesses
    /// use EDI documents to exchange transactional data with trading partners, such as suppliers
    /// and end customers, using standardized formats such as X12.
    /// </para>
    ///  <note> 
    /// <para>
    /// Rather than actually running a command, you can use the <code>--generate-cli-skeleton</code>
    /// parameter with any API call to generate and display a parameter template. You can
    /// then use the generated template to customize and use as input on a later command.
    /// For details, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-skeleton.html#cli-usage-skeleton-generate">Generate
    /// and use a parameter skeleton file</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonB2biClient : AmazonServiceClient, IAmazonB2bi
    {
        private static IServiceMetadata serviceMetadata = new AmazonB2biMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IB2biPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IB2biPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new B2biPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonB2biClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonB2biClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonB2biConfig()) { }

        /// <summary>
        /// Constructs AmazonB2biClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonB2biConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonB2biClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(AmazonB2biConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonB2biClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonB2biClient(AWSCredentials credentials)
            : this(credentials, new AmazonB2biConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonB2biConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Credentials and an
        /// AmazonB2biClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(AWSCredentials credentials, AmazonB2biConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonB2biConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonB2biConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonB2biClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonB2biConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonB2biConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonB2biConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonB2biClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonB2biConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonB2biEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateCapability

        /// <summary>
        /// Instantiates a capability based on the specified parameters. Capabilities contain
        /// the information necessary to process incoming EDI (electronic data interchange) documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability service method.</param>
        /// 
        /// <returns>The response from the CreateCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual CreateCapabilityResponse CreateCapability(CreateCapabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapabilityResponseUnmarshaller.Instance;

            return Invoke<CreateCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual IAsyncResult BeginCreateCapability(CreateCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCapability.</param>
        /// 
        /// <returns>Returns a  CreateCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual CreateCapabilityResponse EndCreateCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePartnership

        /// <summary>
        /// Creates a partnership between a customer and a trading partner, based on the supplied
        /// parameters. Partnerships link trading partners with your profile and a specific transformer,
        /// so that the EDI (electronic data interchange) documents that they upload to Amazon
        /// S3 can be processed according to their specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnership service method.</param>
        /// 
        /// <returns>The response from the CreatePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        public virtual CreatePartnershipResponse CreatePartnership(CreatePartnershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnershipResponseUnmarshaller.Instance;

            return Invoke<CreatePartnershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        public virtual IAsyncResult BeginCreatePartnership(CreatePartnershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartnership.</param>
        /// 
        /// <returns>Returns a  CreatePartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        public virtual CreatePartnershipResponse EndCreatePartnership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePartnershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProfile

        /// <summary>
        /// Creates a customer profile. You can have up to five customer profiles, each representing
        /// a distinct private network. Profiles contain basic information about you and your
        /// business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTransformer

        /// <summary>
        /// Creates a transformer. Transformers describe how to process the incoming EDI (electronic
        /// data interchange) documents, and extract the necessary information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformer service method.</param>
        /// 
        /// <returns>The response from the CreateTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        public virtual CreateTransformerResponse CreateTransformer(CreateTransformerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformerResponseUnmarshaller.Instance;

            return Invoke<CreateTransformerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        public virtual IAsyncResult BeginCreateTransformer(CreateTransformerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransformer.</param>
        /// 
        /// <returns>Returns a  CreateTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        public virtual CreateTransformerResponse EndCreateTransformer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTransformerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCapability

        /// <summary>
        /// Deletes the specified capability. Capabilities contain the information necessary to
        /// process incoming EDI (electronic data interchange) documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability service method.</param>
        /// 
        /// <returns>The response from the DeleteCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual DeleteCapabilityResponse DeleteCapability(DeleteCapabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapabilityResponseUnmarshaller.Instance;

            return Invoke<DeleteCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual IAsyncResult BeginDeleteCapability(DeleteCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCapability.</param>
        /// 
        /// <returns>Returns a  DeleteCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual DeleteCapabilityResponse EndDeleteCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePartnership

        /// <summary>
        /// Deletes the specified partnership. Partnerships link trading partners with your profile
        /// and a specific transformer, so that the EDI (electronic data interchange) documents
        /// that they upload to Amazon S3 can be processed according to their specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnership service method.</param>
        /// 
        /// <returns>The response from the DeletePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        public virtual DeletePartnershipResponse DeletePartnership(DeletePartnershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnershipResponseUnmarshaller.Instance;

            return Invoke<DeletePartnershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        public virtual IAsyncResult BeginDeletePartnership(DeletePartnershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartnership.</param>
        /// 
        /// <returns>Returns a  DeletePartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        public virtual DeletePartnershipResponse EndDeletePartnership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePartnershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProfile

        /// <summary>
        /// Deletes the specified profile. Profiles contain basic information about you and your
        /// business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTransformer

        /// <summary>
        /// Deletes the specified transformer. Transformers describe how to process the incoming
        /// EDI (electronic data interchange) documents, and extract the necessary information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer service method.</param>
        /// 
        /// <returns>The response from the DeleteTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        public virtual DeleteTransformerResponse DeleteTransformer(DeleteTransformerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransformerResponseUnmarshaller.Instance;

            return Invoke<DeleteTransformerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        public virtual IAsyncResult BeginDeleteTransformer(DeleteTransformerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransformerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTransformer.</param>
        /// 
        /// <returns>Returns a  DeleteTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        public virtual DeleteTransformerResponse EndDeleteTransformer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTransformerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCapability

        /// <summary>
        /// Retrieves the details for the specified capability. Capabilities contain the information
        /// necessary to process incoming EDI (electronic data interchange) documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapability service method.</param>
        /// 
        /// <returns>The response from the GetCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        public virtual GetCapabilityResponse GetCapability(GetCapabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCapabilityResponseUnmarshaller.Instance;

            return Invoke<GetCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        public virtual IAsyncResult BeginGetCapability(GetCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCapability.</param>
        /// 
        /// <returns>Returns a  GetCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        public virtual GetCapabilityResponse EndGetCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartnership

        /// <summary>
        /// Retrieves the details for a partnership, based on the partner and profile IDs specified.
        /// Partnerships link trading partners with your profile and a specific transformer, so
        /// that the EDI (electronic data interchange) documents that they upload to Amazon S3
        /// can be processed according to their specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnership service method.</param>
        /// 
        /// <returns>The response from the GetPartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        public virtual GetPartnershipResponse GetPartnership(GetPartnershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnershipResponseUnmarshaller.Instance;

            return Invoke<GetPartnershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        public virtual IAsyncResult BeginGetPartnership(GetPartnershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartnership.</param>
        /// 
        /// <returns>Returns a  GetPartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        public virtual GetPartnershipResponse EndGetPartnership(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartnershipResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfile

        /// <summary>
        /// Retrieves the details for the profile specified by the profile ID. Profiles contain
        /// basic information about you and your business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse EndGetProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTransformer

        /// <summary>
        /// Retrieves the details for the transformer specified by the transformer ID. Transformers
        /// describe how to process the incoming EDI (electronic data interchange) documents,
        /// and extract the necessary information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer service method.</param>
        /// 
        /// <returns>The response from the GetTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        public virtual GetTransformerResponse GetTransformer(GetTransformerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerResponseUnmarshaller.Instance;

            return Invoke<GetTransformerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        public virtual IAsyncResult BeginGetTransformer(GetTransformerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransformer.</param>
        /// 
        /// <returns>Returns a  GetTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        public virtual GetTransformerResponse EndGetTransformer(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTransformerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTransformerJob

        /// <summary>
        /// Returns the details of the transformer run, based on the Transformer job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformerJob service method.</param>
        /// 
        /// <returns>The response from the GetTransformerJob service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        public virtual GetTransformerJobResponse GetTransformerJob(GetTransformerJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerJobResponseUnmarshaller.Instance;

            return Invoke<GetTransformerJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransformerJob operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransformerJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        public virtual IAsyncResult BeginGetTransformerJob(GetTransformerJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransformerJob.</param>
        /// 
        /// <returns>Returns a  GetTransformerJobResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        public virtual GetTransformerJobResponse EndGetTransformerJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTransformerJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCapabilities

        /// <summary>
        /// Lists the capabilities associated with your Amazon Web Services account for your current
        /// or specified region. Capabilities contain the information necessary to process incoming
        /// EDI (electronic data interchange) documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities service method.</param>
        /// 
        /// <returns>The response from the ListCapabilities service method, as returned by B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual ListCapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapabilitiesResponseUnmarshaller.Instance;

            return Invoke<ListCapabilitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCapabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCapabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual IAsyncResult BeginListCapabilities(ListCapabilitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapabilitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCapabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCapabilities.</param>
        /// 
        /// <returns>Returns a  ListCapabilitiesResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual ListCapabilitiesResponse EndListCapabilities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCapabilitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPartnerships

        /// <summary>
        /// Lists the partnerships associated with your Amazon Web Services account for your current
        /// or specified region. Partnerships link trading partners with your profile and a specific
        /// transformer, so that the EDI (electronic data interchange) documents that they upload
        /// to Amazon S3 can be processed according to their specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerships service method.</param>
        /// 
        /// <returns>The response from the ListPartnerships service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        public virtual ListPartnershipsResponse ListPartnerships(ListPartnershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnershipsResponseUnmarshaller.Instance;

            return Invoke<ListPartnershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerships operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        public virtual IAsyncResult BeginListPartnerships(ListPartnershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerships.</param>
        /// 
        /// <returns>Returns a  ListPartnershipsResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        public virtual ListPartnershipsResponse EndListPartnerships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartnershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfiles

        /// <summary>
        /// Lists the profiles associated with your Amazon Web Services account for your current
        /// or specified region. Profiles contain basic information about you and your business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual ListProfilesResponse ListProfiles(ListProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual IAsyncResult BeginListProfiles(ListProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfiles.</param>
        /// 
        /// <returns>Returns a  ListProfilesResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual ListProfilesResponse EndListProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a capability, partnership, profile, or transformer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTransformers

        /// <summary>
        /// Lists the available transformers. Transformers describe how to process the incoming
        /// EDI (electronic data interchange) documents, and extract the necessary information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformers service method.</param>
        /// 
        /// <returns>The response from the ListTransformers service method, as returned by B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        public virtual ListTransformersResponse ListTransformers(ListTransformersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformersResponseUnmarshaller.Instance;

            return Invoke<ListTransformersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTransformers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransformers operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransformers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        public virtual IAsyncResult BeginListTransformers(ListTransformersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransformers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransformers.</param>
        /// 
        /// <returns>Returns a  ListTransformersResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        public virtual ListTransformersResponse EndListTransformers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTransformersResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTransformerJob

        /// <summary>
        /// Runs a job, using a transformer, to parse input EDI (electronic data interchange)
        /// file into the output structures used by Amazon Web Services B2BI Data Interchange.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTransformerJob service method.</param>
        /// 
        /// <returns>The response from the StartTransformerJob service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        public virtual StartTransformerJobResponse StartTransformerJob(StartTransformerJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransformerJobResponseUnmarshaller.Instance;

            return Invoke<StartTransformerJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTransformerJob operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTransformerJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        public virtual IAsyncResult BeginStartTransformerJob(StartTransformerJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransformerJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTransformerJob.</param>
        /// 
        /// <returns>Returns a  StartTransformerJobResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        public virtual StartTransformerJobResponse EndStartTransformerJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTransformerJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are capability, partnership, profile, transformers and other entities.
        /// 
        ///  
        /// <para>
        /// There is no response returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestMapping

        /// <summary>
        /// Maps the input file according to the provided template file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMapping service method.</param>
        /// 
        /// <returns>The response from the TestMapping service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        public virtual TestMappingResponse TestMapping(TestMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMappingResponseUnmarshaller.Instance;

            return Invoke<TestMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestMapping operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        public virtual IAsyncResult BeginTestMapping(TestMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestMapping.</param>
        /// 
        /// <returns>Returns a  TestMappingResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        public virtual TestMappingResponse EndTestMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<TestMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  TestParsing

        /// <summary>
        /// Parses the input EDI (electronic data interchange) file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestParsing service method.</param>
        /// 
        /// <returns>The response from the TestParsing service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        public virtual TestParsingResponse TestParsing(TestParsingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestParsingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestParsingResponseUnmarshaller.Instance;

            return Invoke<TestParsingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestParsing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestParsing operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestParsing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        public virtual IAsyncResult BeginTestParsing(TestParsingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestParsingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestParsingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestParsing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestParsing.</param>
        /// 
        /// <returns>Returns a  TestParsingResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        public virtual TestParsingResponse EndTestParsing(IAsyncResult asyncResult)
        {
            return EndInvoke<TestParsingResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Detaches a key-value pair from the specified resource, as identified by its Amazon
        /// Resource Name (ARN). Resources are capability, partnership, profile, transformers
        /// and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCapability

        /// <summary>
        /// Updates some of the parameters for a capability, based on the specified parameters.
        /// Capabilities contain the information necessary to process incoming EDI (electronic
        /// data interchange) documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability service method.</param>
        /// 
        /// <returns>The response from the UpdateCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual UpdateCapabilityResponse UpdateCapability(UpdateCapabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapabilityResponseUnmarshaller.Instance;

            return Invoke<UpdateCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual IAsyncResult BeginUpdateCapability(UpdateCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCapability.</param>
        /// 
        /// <returns>Returns a  UpdateCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual UpdateCapabilityResponse EndUpdateCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePartnership

        /// <summary>
        /// Updates some of the parameters for a partnership between a customer and trading partner.
        /// Partnerships link trading partners with your profile and a specific transformer, so
        /// that the EDI (electronic data interchange) documents that they upload to Amazon S3
        /// can be processed according to their specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnership service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        public virtual UpdatePartnershipResponse UpdatePartnership(UpdatePartnershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnershipResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        public virtual IAsyncResult BeginUpdatePartnership(UpdatePartnershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartnership.</param>
        /// 
        /// <returns>Returns a  UpdatePartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        public virtual UpdatePartnershipResponse EndUpdatePartnership(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePartnershipResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProfile

        /// <summary>
        /// Updates the specified parameters for a profile. Profiles contain basic information
        /// about you and your business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateProfile(UpdateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTransformer

        /// <summary>
        /// Updates the specified parameters for a transformer. Transformers describe how to process
        /// the incoming EDI (electronic data interchange) documents, and extract the necessary
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTransformer service method.</param>
        /// 
        /// <returns>The response from the UpdateTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        public virtual UpdateTransformerResponse UpdateTransformer(UpdateTransformerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTransformerResponseUnmarshaller.Instance;

            return Invoke<UpdateTransformerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        public virtual IAsyncResult BeginUpdateTransformer(UpdateTransformerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTransformerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTransformer.</param>
        /// 
        /// <returns>Returns a  UpdateTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        public virtual UpdateTransformerResponse EndUpdateTransformer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTransformerResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonB2biEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}