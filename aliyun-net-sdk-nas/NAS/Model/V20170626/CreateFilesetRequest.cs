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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CreateFilesetRequest : RpcAcsRequest<CreateFilesetResponse>
    {
        public CreateFilesetRequest()
            : base("NAS", "2017-06-26", "CreateFileset", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string description;

		private bool? deletionProtection;

		private Quota quota_;

		private string fileSystemId;

		private bool? dryRun;

		private string fileSystemPath;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public bool? DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
				DictionaryUtil.Add(QueryParameters, "DeletionProtection", value.ToString());
			}
		}

		public Quota Quota_
		{
			get
			{
				return quota_;
			}

			set
			{
				quota_ = value;
				if(quota_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"Quota.SizeLimit", quota_.SizeLimit);
					DictionaryUtil.Add(QueryParameters,"Quota.FileCountLimit", quota_.FileCountLimit);
				}
			}
		}

		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

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

		public string FileSystemPath
		{
			get
			{
				return fileSystemPath;
			}
			set	
			{
				fileSystemPath = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemPath", value);
			}
		}

		public class Quota
		{

			private long? sizeLimit;

			private long? fileCountLimit;

			public long? SizeLimit
			{
				get
				{
					return sizeLimit;
				}
				set	
				{
					sizeLimit = value;
				}
			}

			public long? FileCountLimit
			{
				get
				{
					return fileCountLimit;
				}
				set	
				{
					fileCountLimit = value;
				}
			}
		}

        public override CreateFilesetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFilesetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
