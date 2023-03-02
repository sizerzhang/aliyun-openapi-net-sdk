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
using Aliyun.Acs.ltl;
using Aliyun.Acs.ltl.Transform;
using Aliyun.Acs.ltl.Transform.V20190510;

namespace Aliyun.Acs.ltl.Model.V20190510
{
    public class BatchUploadMPCoSPhaseTextInfoByDeviceRequest : RpcAcsRequest<BatchUploadMPCoSPhaseTextInfoByDeviceResponse>
    {
        public BatchUploadMPCoSPhaseTextInfoByDeviceRequest()
            : base("ltl", "2019-05-10", "BatchUploadMPCoSPhaseTextInfoByDevice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotSignature;

		private string iotAuthType;

		private string iotIdSource;

		private string phaseId;

		private string apiVersion;

		private string bizChainId;

		private List<object> phaseDataList;

		private string iotId;

		private string phaseGroupId;

		private string iotDataDigest;

		private string iotIdServiceProvider;

		[JsonProperty(PropertyName = "IotSignature")]
		public string IotSignature
		{
			get
			{
				return iotSignature;
			}
			set	
			{
				iotSignature = value;
				DictionaryUtil.Add(QueryParameters, "IotSignature", value);
			}
		}

		[JsonProperty(PropertyName = "IotAuthType")]
		public string IotAuthType
		{
			get
			{
				return iotAuthType;
			}
			set	
			{
				iotAuthType = value;
				DictionaryUtil.Add(QueryParameters, "IotAuthType", value);
			}
		}

		[JsonProperty(PropertyName = "IotIdSource")]
		public string IotIdSource
		{
			get
			{
				return iotIdSource;
			}
			set	
			{
				iotIdSource = value;
				DictionaryUtil.Add(QueryParameters, "IotIdSource", value);
			}
		}

		[JsonProperty(PropertyName = "PhaseId")]
		public string PhaseId
		{
			get
			{
				return phaseId;
			}
			set	
			{
				phaseId = value;
				DictionaryUtil.Add(QueryParameters, "PhaseId", value);
			}
		}

		[JsonProperty(PropertyName = "ApiVersion")]
		public string ApiVersion
		{
			get
			{
				return apiVersion;
			}
			set	
			{
				apiVersion = value;
				DictionaryUtil.Add(QueryParameters, "ApiVersion", value);
			}
		}

		[JsonProperty(PropertyName = "BizChainId")]
		public string BizChainId
		{
			get
			{
				return bizChainId;
			}
			set	
			{
				bizChainId = value;
				DictionaryUtil.Add(QueryParameters, "BizChainId", value);
			}
		}

		[JsonProperty(PropertyName = "PhaseDataList")]
		public List<object> PhaseDataList
		{
			get
			{
				return phaseDataList;
			}
			set	
			{
				phaseDataList = value;
				DictionaryUtil.Add(QueryParameters, "PhaseDataList", JsonConvert.SerializeObject(value));
			}
		}

		[JsonProperty(PropertyName = "IotId")]
		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		[JsonProperty(PropertyName = "PhaseGroupId")]
		public string PhaseGroupId
		{
			get
			{
				return phaseGroupId;
			}
			set	
			{
				phaseGroupId = value;
				DictionaryUtil.Add(QueryParameters, "PhaseGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "IotDataDigest")]
		public string IotDataDigest
		{
			get
			{
				return iotDataDigest;
			}
			set	
			{
				iotDataDigest = value;
				DictionaryUtil.Add(QueryParameters, "IotDataDigest", value);
			}
		}

		[JsonProperty(PropertyName = "IotIdServiceProvider")]
		public string IotIdServiceProvider
		{
			get
			{
				return iotIdServiceProvider;
			}
			set	
			{
				iotIdServiceProvider = value;
				DictionaryUtil.Add(QueryParameters, "IotIdServiceProvider", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchUploadMPCoSPhaseTextInfoByDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchUploadMPCoSPhaseTextInfoByDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
