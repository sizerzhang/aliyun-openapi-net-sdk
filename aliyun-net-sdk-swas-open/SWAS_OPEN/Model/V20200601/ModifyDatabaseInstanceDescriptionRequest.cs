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
using Aliyun.Acs.SWAS_OPEN.Transform;
using Aliyun.Acs.SWAS_OPEN.Transform.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
    public class ModifyDatabaseInstanceDescriptionRequest : RpcAcsRequest<ModifyDatabaseInstanceDescriptionResponse>
    {
        public ModifyDatabaseInstanceDescriptionRequest()
            : base("SWAS-OPEN", "2020-06-01", "ModifyDatabaseInstanceDescription", "SWAS-OPEN", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string clientToken;

		private string databaseInstanceId;

		private string databaseInstanceDescription;

		[JsonProperty(PropertyName = "ClientToken")]
		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		[JsonProperty(PropertyName = "DatabaseInstanceId")]
		public string DatabaseInstanceId
		{
			get
			{
				return databaseInstanceId;
			}
			set	
			{
				databaseInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "DatabaseInstanceDescription")]
		public string DatabaseInstanceDescription
		{
			get
			{
				return databaseInstanceDescription;
			}
			set	
			{
				databaseInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseInstanceDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDatabaseInstanceDescriptionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDatabaseInstanceDescriptionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
