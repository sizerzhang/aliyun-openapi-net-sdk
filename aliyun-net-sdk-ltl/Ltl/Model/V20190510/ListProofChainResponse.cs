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

namespace Aliyun.Acs.ltl.Model.V20190510
{
	public class ListProofChainResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private ListProofChain_Data data;

		[JsonProperty(PropertyName = "Code")]
		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public ListProofChain_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListProofChain_Data
		{

			private int? num;

			private int? total;

			private int? size;

			private List<ListProofChain_ProofChainInfo> pageData;

			[JsonProperty(PropertyName = "Num")]
			public int? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
				}
			}

			[JsonProperty(PropertyName = "Total")]
			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			[JsonProperty(PropertyName = "Size")]
			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			[JsonProperty(PropertyName = "PageData")]
			public List<ListProofChain_ProofChainInfo> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class ListProofChain_ProofChainInfo
			{

				private string remark;

				private string bizChainId;

				private string roleType;

				private string bizChainCode;

				private string name;

				private string dataTypeCode;

				[JsonProperty(PropertyName = "Remark")]
				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
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
					}
				}

				[JsonProperty(PropertyName = "RoleType")]
				public string RoleType
				{
					get
					{
						return roleType;
					}
					set	
					{
						roleType = value;
					}
				}

				[JsonProperty(PropertyName = "BizChainCode")]
				public string BizChainCode
				{
					get
					{
						return bizChainCode;
					}
					set	
					{
						bizChainCode = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "DataTypeCode")]
				public string DataTypeCode
				{
					get
					{
						return dataTypeCode;
					}
					set	
					{
						dataTypeCode = value;
					}
				}
			}
		}
	}
}
