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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Dimensions Object
    /// </summary>  
    public class DimensionsUnmarshaller : IUnmarshaller<Dimensions, XmlUnmarshallerContext>, IUnmarshaller<Dimensions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Dimensions IUnmarshaller<Dimensions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Dimensions Unmarshall(JsonUnmarshallerContext context)
        {
            Dimensions unmarshalledObject = new Dimensions();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Channel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Queue", targetDepth))
                {
                    var unmarshaller = QueueReferenceUnmarshaller.Instance;
                    unmarshalledObject.Queue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoutingProfile", targetDepth))
                {
                    var unmarshaller = RoutingProfileReferenceUnmarshaller.Instance;
                    unmarshalledObject.RoutingProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DimensionsUnmarshaller _instance = new DimensionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DimensionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}