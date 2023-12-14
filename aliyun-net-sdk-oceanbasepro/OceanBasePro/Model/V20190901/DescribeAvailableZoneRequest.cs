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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class DescribeAvailableZoneRequest : RpcAcsRequest<DescribeAvailableZoneResponse>
    {
        public DescribeAvailableZoneRequest()
            : base("OceanBasePro", "2019-09-01", "DescribeAvailableZone", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string spec;

		private string obVersion;

		private string series;

		private string instanceType;

		private string deployType;

		[JsonProperty(PropertyName = "Spec")]
		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
				DictionaryUtil.Add(BodyParameters, "Spec", value);
			}
		}

		[JsonProperty(PropertyName = "ObVersion")]
		public string ObVersion
		{
			get
			{
				return obVersion;
			}
			set	
			{
				obVersion = value;
				DictionaryUtil.Add(BodyParameters, "ObVersion", value);
			}
		}

		[JsonProperty(PropertyName = "Series")]
		public string Series
		{
			get
			{
				return series;
			}
			set	
			{
				series = value;
				DictionaryUtil.Add(BodyParameters, "Series", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceType")]
		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(BodyParameters, "InstanceType", value);
			}
		}

		[JsonProperty(PropertyName = "DeployType")]
		public string DeployType
		{
			get
			{
				return deployType;
			}
			set	
			{
				deployType = value;
				DictionaryUtil.Add(BodyParameters, "DeployType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAvailableZoneResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAvailableZoneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
