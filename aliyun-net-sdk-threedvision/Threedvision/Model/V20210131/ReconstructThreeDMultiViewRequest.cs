/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.threedvision.Transform;
using Aliyun.Acs.threedvision.Transform.V20210131;

namespace Aliyun.Acs.threedvision.Model.V20210131
{
    public class ReconstructThreeDMultiViewRequest : RpcAcsRequest<ReconstructThreeDMultiViewResponse>
    {
        public ReconstructThreeDMultiViewRequest()
            : base("threedvision", "2021-01-31", "ReconstructThreeDMultiView", "threedvision", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.threedvision.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.threedvision.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string mode;

		private string zipFileUrl;

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(BodyParameters, "Mode", value);
			}
		}

		public string ZipFileUrl
		{
			get
			{
				return zipFileUrl;
			}
			set	
			{
				zipFileUrl = value;
				DictionaryUtil.Add(BodyParameters, "ZipFileUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ReconstructThreeDMultiViewResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReconstructThreeDMultiViewResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
