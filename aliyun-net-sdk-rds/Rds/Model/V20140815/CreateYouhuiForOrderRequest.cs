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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateYouhuiForOrderRequest : RpcAcsRequest<CreateYouhuiForOrderResponse>
    {
        public CreateYouhuiForOrderRequest()
            : base("Rds", "2014-08-15", "CreateYouhuiForOrder", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerId;

		private long? promotionId;

		private long? activityId;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public string ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "PromotionId")]
		public long? PromotionId
		{
			get
			{
				return promotionId;
			}
			set	
			{
				promotionId = value;
				DictionaryUtil.Add(QueryParameters, "PromotionId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ActivityId")]
		public long? ActivityId
		{
			get
			{
				return activityId;
			}
			set	
			{
				activityId = value;
				DictionaryUtil.Add(QueryParameters, "ActivityId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateYouhuiForOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateYouhuiForOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
