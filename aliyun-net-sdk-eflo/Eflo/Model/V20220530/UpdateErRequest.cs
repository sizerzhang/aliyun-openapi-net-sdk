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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class UpdateErRequest : RpcAcsRequest<UpdateErResponse>
    {
        public UpdateErRequest()
            : base("eflo", "2022-05-30", "UpdateEr", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string erId;

		private string description;

		private string erName;

		public string ErId
		{
			get
			{
				return erId;
			}
			set	
			{
				erId = value;
				DictionaryUtil.Add(BodyParameters, "ErId", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string ErName
		{
			get
			{
				return erName;
			}
			set	
			{
				erName = value;
				DictionaryUtil.Add(BodyParameters, "ErName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateErResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateErResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
