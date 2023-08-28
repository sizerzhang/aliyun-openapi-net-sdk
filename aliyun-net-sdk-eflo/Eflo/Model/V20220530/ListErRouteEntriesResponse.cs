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
	public class ListErRouteEntriesResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListErRouteEntries_Content content;

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

		public ListErRouteEntries_Content Content
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

		public class ListErRouteEntries_Content
		{

			private long? total;

			private List<ListErRouteEntries_DataItem> data;

			public long? Total
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

			public List<ListErRouteEntries_DataItem> Data
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

			public class ListErRouteEntries_DataItem
			{

				private string erId;

				private string tenantId;

				private string resourceTenantId;

				private string regionId;

				private string erRouteEntryId;

				private string destinationCidrBlock;

				private string nextHopType;

				private string nextHopId;

				private string routeType;

				private string status;

				private string gmtModified;

				public string ErId
				{
					get
					{
						return erId;
					}
					set	
					{
						erId = value;
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

				public string ResourceTenantId
				{
					get
					{
						return resourceTenantId;
					}
					set	
					{
						resourceTenantId = value;
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

				public string ErRouteEntryId
				{
					get
					{
						return erRouteEntryId;
					}
					set	
					{
						erRouteEntryId = value;
					}
				}

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
					}
				}

				public string NextHopType
				{
					get
					{
						return nextHopType;
					}
					set	
					{
						nextHopType = value;
					}
				}

				public string NextHopId
				{
					get
					{
						return nextHopId;
					}
					set	
					{
						nextHopId = value;
					}
				}

				public string RouteType
				{
					get
					{
						return routeType;
					}
					set	
					{
						routeType = value;
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
			}
		}
	}
}
