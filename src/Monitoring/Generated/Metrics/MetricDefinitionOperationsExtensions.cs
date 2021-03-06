// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics
{
    public static partial class MetricDefinitionOperationsExtensions
    {
        /// <summary>
        /// The List Metric Definitions operation lists the metric definitions
        /// for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricDefinitionOperations.
        /// </param>
        /// <param name='resourceId'>
        /// The id of the resource.The resource id can be built using the
        /// resource id builder class under utilities
        /// </param>
        /// <param name='metricNames'>
        /// The names of the metrics.
        /// </param>
        /// <param name='metricNamespace'>
        /// The namespace of the metrics.The value is either null or
        /// WindowsAzure.Availability.WindowsAzure.Availability returns the
        /// metric definitions for endpoint monitoring metrics
        /// </param>
        /// <returns>
        /// The List Metric Definitions operation response.
        /// </returns>
        public static MetricDefinitionListResponse List(this IMetricDefinitionOperations operations, string resourceId, IList<string> metricNames, string metricNamespace)
        {
            try
            {
                return operations.ListAsync(resourceId, metricNames, metricNamespace).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The List Metric Definitions operation lists the metric definitions
        /// for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricDefinitionOperations.
        /// </param>
        /// <param name='resourceId'>
        /// The id of the resource.The resource id can be built using the
        /// resource id builder class under utilities
        /// </param>
        /// <param name='metricNames'>
        /// The names of the metrics.
        /// </param>
        /// <param name='metricNamespace'>
        /// The namespace of the metrics.The value is either null or
        /// WindowsAzure.Availability.WindowsAzure.Availability returns the
        /// metric definitions for endpoint monitoring metrics
        /// </param>
        /// <returns>
        /// The List Metric Definitions operation response.
        /// </returns>
        public static Task<MetricDefinitionListResponse> ListAsync(this IMetricDefinitionOperations operations, string resourceId, IList<string> metricNames, string metricNamespace)
        {
            return operations.ListAsync(resourceId, metricNames, metricNamespace, CancellationToken.None);
        }
    }
}
