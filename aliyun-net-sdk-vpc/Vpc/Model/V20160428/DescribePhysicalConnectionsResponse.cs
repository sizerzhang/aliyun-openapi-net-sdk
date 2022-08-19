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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribePhysicalConnectionsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribePhysicalConnections_PhysicalConnectionType> physicalConnectionSet;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribePhysicalConnections_PhysicalConnectionType> PhysicalConnectionSet
		{
			get
			{
				return physicalConnectionSet;
			}
			set	
			{
				physicalConnectionSet = value;
			}
		}

		public class DescribePhysicalConnections_PhysicalConnectionType
		{

			private string type;

			private string status;

			private string creationTime;

			private string adLocation;

			private string reservationActiveTime;

			private string reservationOrderType;

			private string portNumber;

			private string spec;

			private string chargeType;

			private string reservationInternetChargeType;

			private string description;

			private long? bandwidth;

			private string enabledTime;

			private string lineOperator;

			private string peerLocation;

			private string redundantPhysicalConnectionId;

			private string name;

			private string circuitCode;

			private string endTime;

			private string portType;

			private string businessStatus;

			private string loaStatus;

			private string accessPointId;

			private string accessPointType;

			private string hasReservationData;

			private string physicalConnectionId;

			private string productType;

			private int? virtualPhysicalConnectionCount;

			private string parentPhysicalConnectionId;

			private long? parentPhysicalConnectionAliUid;

			private string vlanId;

			private string orderMode;

			private string vpconnStatus;

			private string expectSpec;

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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string AdLocation
			{
				get
				{
					return adLocation;
				}
				set	
				{
					adLocation = value;
				}
			}

			public string ReservationActiveTime
			{
				get
				{
					return reservationActiveTime;
				}
				set	
				{
					reservationActiveTime = value;
				}
			}

			public string ReservationOrderType
			{
				get
				{
					return reservationOrderType;
				}
				set	
				{
					reservationOrderType = value;
				}
			}

			public string PortNumber
			{
				get
				{
					return portNumber;
				}
				set	
				{
					portNumber = value;
				}
			}

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string ReservationInternetChargeType
			{
				get
				{
					return reservationInternetChargeType;
				}
				set	
				{
					reservationInternetChargeType = value;
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
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string EnabledTime
			{
				get
				{
					return enabledTime;
				}
				set	
				{
					enabledTime = value;
				}
			}

			public string LineOperator
			{
				get
				{
					return lineOperator;
				}
				set	
				{
					lineOperator = value;
				}
			}

			public string PeerLocation
			{
				get
				{
					return peerLocation;
				}
				set	
				{
					peerLocation = value;
				}
			}

			public string RedundantPhysicalConnectionId
			{
				get
				{
					return redundantPhysicalConnectionId;
				}
				set	
				{
					redundantPhysicalConnectionId = value;
				}
			}

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

			public string CircuitCode
			{
				get
				{
					return circuitCode;
				}
				set	
				{
					circuitCode = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string PortType
			{
				get
				{
					return portType;
				}
				set	
				{
					portType = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string LoaStatus
			{
				get
				{
					return loaStatus;
				}
				set	
				{
					loaStatus = value;
				}
			}

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}

			public string AccessPointType
			{
				get
				{
					return accessPointType;
				}
				set	
				{
					accessPointType = value;
				}
			}

			public string HasReservationData
			{
				get
				{
					return hasReservationData;
				}
				set	
				{
					hasReservationData = value;
				}
			}

			public string PhysicalConnectionId
			{
				get
				{
					return physicalConnectionId;
				}
				set	
				{
					physicalConnectionId = value;
				}
			}

			public string ProductType
			{
				get
				{
					return productType;
				}
				set	
				{
					productType = value;
				}
			}

			public int? VirtualPhysicalConnectionCount
			{
				get
				{
					return virtualPhysicalConnectionCount;
				}
				set	
				{
					virtualPhysicalConnectionCount = value;
				}
			}

			public string ParentPhysicalConnectionId
			{
				get
				{
					return parentPhysicalConnectionId;
				}
				set	
				{
					parentPhysicalConnectionId = value;
				}
			}

			public long? ParentPhysicalConnectionAliUid
			{
				get
				{
					return parentPhysicalConnectionAliUid;
				}
				set	
				{
					parentPhysicalConnectionAliUid = value;
				}
			}

			public string VlanId
			{
				get
				{
					return vlanId;
				}
				set	
				{
					vlanId = value;
				}
			}

			public string OrderMode
			{
				get
				{
					return orderMode;
				}
				set	
				{
					orderMode = value;
				}
			}

			public string VpconnStatus
			{
				get
				{
					return vpconnStatus;
				}
				set	
				{
					vpconnStatus = value;
				}
			}

			public string ExpectSpec
			{
				get
				{
					return expectSpec;
				}
				set	
				{
					expectSpec = value;
				}
			}
		}
	}
}
