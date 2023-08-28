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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetSubnetResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetSubnet_Content content;

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

		public GetSubnet_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class GetSubnet_Content
		{

			private string createTime;

			private string gmtModified;

			private string tenantId;

			private string regionId;

			private string zoneId;

			private string subnetId;

			private string subnetName;

			private string cidr;

			private string vpdId;

			private string type;

			private string status;

			private string message;

			private int? ncCount;

			private int? networkInterfaceCount;

			private long? lbCount;

			private string resourceGroupId;

			private long? privateIpCount;

			private int? availableIps;

			private List<GetSubnet_Tag> tags;

			private GetSubnet_VpdBaseInfo vpdBaseInfo;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string SubnetId
			{
				get
				{
					return subnetId;
				}
				set	
				{
					subnetId = value;
				}
			}

			public string SubnetName
			{
				get
				{
					return subnetName;
				}
				set	
				{
					subnetName = value;
				}
			}

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}

			public string VpdId
			{
				get
				{
					return vpdId;
				}
				set	
				{
					vpdId = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

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

			public int? NcCount
			{
				get
				{
					return ncCount;
				}
				set	
				{
					ncCount = value;
				}
			}

			public int? NetworkInterfaceCount
			{
				get
				{
					return networkInterfaceCount;
				}
				set	
				{
					networkInterfaceCount = value;
				}
			}

			public long? LbCount
			{
				get
				{
					return lbCount;
				}
				set	
				{
					lbCount = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public long? PrivateIpCount
			{
				get
				{
					return privateIpCount;
				}
				set	
				{
					privateIpCount = value;
				}
			}

			public int? AvailableIps
			{
				get
				{
					return availableIps;
				}
				set	
				{
					availableIps = value;
				}
			}

			public List<GetSubnet_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public GetSubnet_VpdBaseInfo VpdBaseInfo
			{
				get
				{
					return vpdBaseInfo;
				}
				set	
				{
					vpdBaseInfo = value;
				}
			}

			public class GetSubnet_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class GetSubnet_VpdBaseInfo
			{

				private string vpdId;

				private string vpdName;

				private string cidr;

				private string createTime;

				public string VpdId
				{
					get
					{
						return vpdId;
					}
					set	
					{
						vpdId = value;
					}
				}

				public string VpdName
				{
					get
					{
						return vpdName;
					}
					set	
					{
						vpdName = value;
					}
				}

				public string Cidr
				{
					get
					{
						return cidr;
					}
					set	
					{
						cidr = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}
			}
		}
	}
}
