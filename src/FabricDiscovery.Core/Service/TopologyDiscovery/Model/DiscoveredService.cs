﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using Yarp.ServiceFabric.ServiceFabricIntegration;

namespace Yarp.ServiceFabric.FabricDiscovery.Topology
{
    internal record DiscoveredService
    {
        public DiscoveredService(DiscoveredServiceType serviceType, ServiceWrapper service)
        {
            this.ServiceType = serviceType ?? throw new ArgumentNullException(nameof(serviceType));
            this.Service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public DiscoveredServiceType ServiceType { get; }
        public ServiceWrapper Service { get; }
    }
}
