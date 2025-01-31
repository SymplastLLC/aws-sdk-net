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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BCMDataExports.Model;

namespace Amazon.BCMDataExports
{
    /// <summary>
    /// Interface for accessing BCMDataExports
    ///
    /// You can use the Data Exports API to create customized exports from multiple Amazon
    /// Web Services cost management and billing datasets, such as cost and usage data and
    /// cost optimization recommendations.
    /// 
    ///  
    /// <para>
    /// The Data Exports API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://bcm-data-exports.us-east-1.api.aws
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonBCMDataExports : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBCMDataExportsPaginatorFactory Paginators { get; }

        
        #region  CreateExport


        /// <summary>
        /// Creates a data export and specifies the data query, the delivery preference, and any
        /// optional resource tags.
        /// 
        ///  
        /// <para>
        /// A <code>DataQuery</code> consists of both a <code>QueryStatement</code> and <code>TableConfigurations</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>QueryStatement</code> is an SQL statement. Data Exports only supports a
        /// limited subset of the SQL syntax. For more information on the SQL syntax that is supported,
        /// see <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-data-query.html">Data
        /// query</a>. To view the available tables and columns, see the <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-table-dictionary.html">Data
        /// Exports table dictionary</a>.
        /// </para>
        ///  
        /// <para>
        /// The <code>TableConfigurations</code> is a collection of specified <code>TableProperties</code>
        /// for the table being queried in the <code>QueryStatement</code>. TableProperties are
        /// additional configurations you can provide to change the data and schema of a table.
        /// Each table can have different TableProperties. However, tables are not required to
        /// have any TableProperties. Each table property has a default value that it assumes
        /// if not specified. For more information on table configurations, see <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-data-query.html">Data
        /// query</a>. To view the table properties available for each table, see the <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-table-dictionary.html">Data
        /// Exports table dictionary</a> or use the <code>ListTables</code> API to get a response
        /// of all tables and their available properties.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExport service method.</param>
        /// 
        /// <returns>The response from the CreateExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/CreateExport">REST API Reference for CreateExport Operation</seealso>
        CreateExportResponse CreateExport(CreateExportRequest request);



        /// <summary>
        /// Creates a data export and specifies the data query, the delivery preference, and any
        /// optional resource tags.
        /// 
        ///  
        /// <para>
        /// A <code>DataQuery</code> consists of both a <code>QueryStatement</code> and <code>TableConfigurations</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>QueryStatement</code> is an SQL statement. Data Exports only supports a
        /// limited subset of the SQL syntax. For more information on the SQL syntax that is supported,
        /// see <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-data-query.html">Data
        /// query</a>. To view the available tables and columns, see the <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-table-dictionary.html">Data
        /// Exports table dictionary</a>.
        /// </para>
        ///  
        /// <para>
        /// The <code>TableConfigurations</code> is a collection of specified <code>TableProperties</code>
        /// for the table being queried in the <code>QueryStatement</code>. TableProperties are
        /// additional configurations you can provide to change the data and schema of a table.
        /// Each table can have different TableProperties. However, tables are not required to
        /// have any TableProperties. Each table property has a default value that it assumes
        /// if not specified. For more information on table configurations, see <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-data-query.html">Data
        /// query</a>. To view the table properties available for each table, see the <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-table-dictionary.html">Data
        /// Exports table dictionary</a> or use the <code>ListTables</code> API to get a response
        /// of all tables and their available properties.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/CreateExport">REST API Reference for CreateExport Operation</seealso>
        Task<CreateExportResponse> CreateExportAsync(CreateExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteExport


        /// <summary>
        /// Deletes an existing data export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExport service method.</param>
        /// 
        /// <returns>The response from the DeleteExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/DeleteExport">REST API Reference for DeleteExport Operation</seealso>
        DeleteExportResponse DeleteExport(DeleteExportRequest request);



        /// <summary>
        /// Deletes an existing data export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/DeleteExport">REST API Reference for DeleteExport Operation</seealso>
        Task<DeleteExportResponse> DeleteExportAsync(DeleteExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExecution


        /// <summary>
        /// Exports data based on the source data update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExecution service method.</param>
        /// 
        /// <returns>The response from the GetExecution service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/GetExecution">REST API Reference for GetExecution Operation</seealso>
        GetExecutionResponse GetExecution(GetExecutionRequest request);



        /// <summary>
        /// Exports data based on the source data update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExecution service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/GetExecution">REST API Reference for GetExecution Operation</seealso>
        Task<GetExecutionResponse> GetExecutionAsync(GetExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExport


        /// <summary>
        /// Views the definition of an existing data export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/GetExport">REST API Reference for GetExport Operation</seealso>
        GetExportResponse GetExport(GetExportRequest request);



        /// <summary>
        /// Views the definition of an existing data export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/GetExport">REST API Reference for GetExport Operation</seealso>
        Task<GetExportResponse> GetExportAsync(GetExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTable


        /// <summary>
        /// Returns the metadata for the specified table and table properties. This includes the
        /// list of columns in the table schema, their data types, and column descriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/GetTable">REST API Reference for GetTable Operation</seealso>
        GetTableResponse GetTable(GetTableRequest request);



        /// <summary>
        /// Returns the metadata for the specified table and table properties. This includes the
        /// list of columns in the table schema, their data types, and column descriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/GetTable">REST API Reference for GetTable Operation</seealso>
        Task<GetTableResponse> GetTableAsync(GetTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExecutions


        /// <summary>
        /// Lists the historical executions for the export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse ListExecutions(ListExecutionsRequest request);



        /// <summary>
        /// Lists the historical executions for the export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists all data export definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);



        /// <summary>
        /// Lists all data export definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListExports">REST API Reference for ListExports Operation</seealso>
        Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTables


        /// <summary>
        /// Lists all available tables in data exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);



        /// <summary>
        /// Lists all available tables in data exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListTables">REST API Reference for ListTables Operation</seealso>
        Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags associated with an existing data export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List tags associated with an existing data export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags for an existing data export definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags for an existing data export definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes tags associated with an existing data export definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes tags associated with an existing data export definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateExport


        /// <summary>
        /// Updates an existing data export by overwriting all export parameters. All export parameters
        /// must be provided in the UpdateExport request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExport service method.</param>
        /// 
        /// <returns>The response from the UpdateExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/UpdateExport">REST API Reference for UpdateExport Operation</seealso>
        UpdateExportResponse UpdateExport(UpdateExportRequest request);



        /// <summary>
        /// Updates an existing data export by overwriting all export parameters. All export parameters
        /// must be provided in the UpdateExport request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExport service method, as returned by BCMDataExports.</returns>
        /// <exception cref="Amazon.BCMDataExports.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMDataExports.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-data-exports-2023-11-26/UpdateExport">REST API Reference for UpdateExport Operation</seealso>
        Task<UpdateExportResponse> UpdateExportAsync(UpdateExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}