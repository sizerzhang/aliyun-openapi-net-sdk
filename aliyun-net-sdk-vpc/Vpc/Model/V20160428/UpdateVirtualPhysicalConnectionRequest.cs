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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class UpdateVirtualPhysicalConnectionRequest : RpcAcsRequest<UpdateVirtualPhysicalConnectionResponse>
    {
        public UpdateVirtualPhysicalConnectionRequest()
            : base("Vpc", "2016-04-28", "UpdateVirtualPhysicalConnection", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? dryRun;

		private long? vlanId;

		private string token;

		private string instanceId;

		private string expectSpec;

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public long? VlanId
		{
			get
			{
				return vlanId;
			}
			set	
			{
				vlanId = value;
				DictionaryUtil.Add(QueryParameters, "VlanId", value.ToString());
			}
		}

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "Token", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ExpectSpec
		{
			get
			{
				return expectSpec;
			}
			set	
			{
				expectSpec = value;
				DictionaryUtil.Add(QueryParameters, "ExpectSpec", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateVirtualPhysicalConnectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateVirtualPhysicalConnectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
