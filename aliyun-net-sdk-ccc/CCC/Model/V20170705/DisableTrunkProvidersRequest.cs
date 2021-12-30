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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class DisableTrunkProvidersRequest : RpcAcsRequest<DisableTrunkProvidersResponse>
    {
        public DisableTrunkProvidersRequest()
            : base("CCC", "2017-07-05", "DisableTrunkProviders")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> providerNames = new List<string>(){ };

		public List<string> ProviderNames
		{
			get
			{
				return providerNames;
			}

			set
			{
				providerNames = value;
				for (int i = 0; i < providerNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ProviderName." + (i + 1) , providerNames[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DisableTrunkProvidersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DisableTrunkProvidersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
