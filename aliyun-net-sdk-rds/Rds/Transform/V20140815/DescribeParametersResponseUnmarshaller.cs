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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

			describeParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersResponse.RequestId = _ctx.StringValue("DescribeParameters.RequestId");
			describeParametersResponse.Engine = _ctx.StringValue("DescribeParameters.Engine");
			describeParametersResponse.EngineVersion = _ctx.StringValue("DescribeParameters.EngineVersion");

			DescribeParametersResponse.DescribeParameters_ParamGroupInfo paramGroupInfo = new DescribeParametersResponse.DescribeParameters_ParamGroupInfo();
			paramGroupInfo.ParameterGroupName = _ctx.StringValue("DescribeParameters.ParamGroupInfo.ParameterGroupName");
			paramGroupInfo.ParameterGroupDesc = _ctx.StringValue("DescribeParameters.ParamGroupInfo.ParameterGroupDesc");
			paramGroupInfo.ParameterGroupType = _ctx.StringValue("DescribeParameters.ParamGroupInfo.ParameterGroupType");
			paramGroupInfo.ParamGroupId = _ctx.StringValue("DescribeParameters.ParamGroupInfo.ParamGroupId");
			describeParametersResponse.ParamGroupInfo = paramGroupInfo;

			List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter> describeParametersResponse_configParameters = new List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.ConfigParameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DescribeParameters_DBInstanceParameter();
				dBInstanceParameter.ParameterDescription = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ParameterDescription");
				dBInstanceParameter.ParameterName = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ParameterName");
				dBInstanceParameter.ParameterValue = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ParameterValue");

				describeParametersResponse_configParameters.Add(dBInstanceParameter);
			}
			describeParametersResponse.ConfigParameters = describeParametersResponse_configParameters;

			List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter1> describeParametersResponse_runningParameters = new List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter1>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.RunningParameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_DBInstanceParameter1 dBInstanceParameter1 = new DescribeParametersResponse.DescribeParameters_DBInstanceParameter1();
				dBInstanceParameter1.ParameterDescription = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterDescription");
				dBInstanceParameter1.ParameterName = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterName");
				dBInstanceParameter1.ParameterValue = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterValue");
				dBInstanceParameter1.ParameterValueRange = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterValueRange");
				dBInstanceParameter1.ParameterDefaultValue = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterDefaultValue");

				describeParametersResponse_runningParameters.Add(dBInstanceParameter1);
			}
			describeParametersResponse.RunningParameters = describeParametersResponse_runningParameters;
        
			return describeParametersResponse;
        }
    }
}
