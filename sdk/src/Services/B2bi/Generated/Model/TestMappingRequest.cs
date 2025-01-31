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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the TestMapping operation.
    /// Maps the input file according to the provided template file.
    /// </summary>
    public partial class TestMappingRequest : AmazonB2biRequest
    {
        private FileFormat _fileFormat;
        private string _inputFileContent;
        private string _mappingTemplate;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Specifies that the currently supported file formats for EDI transformations are <code>JSON</code>
        /// and <code>XML</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileFormat FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property InputFileContent. 
        /// <para>
        /// Specify the EDI (electronic data interchange) file that is used as input for the transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200000)]
        public string InputFileContent
        {
            get { return this._inputFileContent; }
            set { this._inputFileContent = value; }
        }

        // Check to see if InputFileContent property is set
        internal bool IsSetInputFileContent()
        {
            return this._inputFileContent != null;
        }

        /// <summary>
        /// Gets and sets the property MappingTemplate. 
        /// <para>
        /// Specifies the name of the mapping template for the transformer. This template is used
        /// to convert the input document into the correct set of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=350000)]
        public string MappingTemplate
        {
            get { return this._mappingTemplate; }
            set { this._mappingTemplate = value; }
        }

        // Check to see if MappingTemplate property is set
        internal bool IsSetMappingTemplate()
        {
            return this._mappingTemplate != null;
        }

    }
}