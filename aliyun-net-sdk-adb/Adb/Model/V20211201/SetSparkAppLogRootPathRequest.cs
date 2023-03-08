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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20211201;

namespace Aliyun.Acs.adb.Model.V20211201
{
    public class SetSparkAppLogRootPathRequest : RpcAcsRequest<SetSparkAppLogRootPathResponse>
    {
        public SetSparkAppLogRootPathRequest()
            : base("adb", "2021-12-01", "SetSparkAppLogRootPath", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBClusterId;

		private bool? useDefaultOss;

		private string ossLogPath;

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(BodyParameters, "DBClusterId", value);
			}
		}

		public bool? UseDefaultOss
		{
			get
			{
				return useDefaultOss;
			}
			set	
			{
				useDefaultOss = value;
				DictionaryUtil.Add(BodyParameters, "UseDefaultOss", value.ToString());
			}
		}

		public string OssLogPath
		{
			get
			{
				return ossLogPath;
			}
			set	
			{
				ossLogPath = value;
				DictionaryUtil.Add(BodyParameters, "OssLogPath", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetSparkAppLogRootPathResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetSparkAppLogRootPathResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
