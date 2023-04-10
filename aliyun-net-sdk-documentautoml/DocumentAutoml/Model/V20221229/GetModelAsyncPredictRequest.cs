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
using Aliyun.Acs.documentAutoml.Transform;
using Aliyun.Acs.documentAutoml.Transform.V20221229;

namespace Aliyun.Acs.documentAutoml.Model.V20221229
{
    public class GetModelAsyncPredictRequest : RpcAcsRequest<GetModelAsyncPredictResponse>
    {
        public GetModelAsyncPredictRequest()
            : base("documentAutoml", "2022-12-29", "GetModelAsyncPredict", "documentAutoml", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? asyncPredictId;

		public long? AsyncPredictId
		{
			get
			{
				return asyncPredictId;
			}
			set	
			{
				asyncPredictId = value;
				DictionaryUtil.Add(QueryParameters, "AsyncPredictId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetModelAsyncPredictResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetModelAsyncPredictResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
