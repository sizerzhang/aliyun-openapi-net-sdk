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
    public class GetHistoryDataListRequest : RpcAcsRequest<GetHistoryDataListResponse>
    {
        public GetHistoryDataListRequest()
            : base("ltl", "2019-05-10", "GetHistoryDataList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? endTime;

		private string apiVersion;

		private int? currentPage;

		private long? startTime;

		private string productKey;

		private int? pageSize;

		private string key;

		[JsonProperty(PropertyName = "EndTime")]
		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
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

		[JsonProperty(PropertyName = "CurrentPage")]
		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "StartTime")]
		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ProductKey")]
		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Key")]
		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(QueryParameters, "Key", value);
			}
		}

        public override GetHistoryDataListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetHistoryDataListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
