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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class QueryCubePerformanceRequest : RpcAcsRequest<QueryCubePerformanceResponse>
    {
        public QueryCubePerformanceRequest()
            : base("quickbi-public", "2022-01-01", "QueryCubePerformance", "2.2.0", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? pageNum;

		private int? pageSize;

		private int? costTimeAvgMin;

		private string queryType;

		private string cubeId;

		private string workspaceId;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

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

		public int? CostTimeAvgMin
		{
			get
			{
				return costTimeAvgMin;
			}
			set	
			{
				costTimeAvgMin = value;
				DictionaryUtil.Add(QueryParameters, "CostTimeAvgMin", value.ToString());
			}
		}

		public string QueryType
		{
			get
			{
				return queryType;
			}
			set	
			{
				queryType = value;
				DictionaryUtil.Add(QueryParameters, "QueryType", value);
			}
		}

		public string CubeId
		{
			get
			{
				return cubeId;
			}
			set	
			{
				cubeId = value;
				DictionaryUtil.Add(QueryParameters, "CubeId", value);
			}
		}

		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryCubePerformanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryCubePerformanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
