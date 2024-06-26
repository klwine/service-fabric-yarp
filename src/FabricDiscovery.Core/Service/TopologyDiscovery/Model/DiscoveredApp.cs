﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using Yarp.ServiceFabric.ServiceFabricIntegration;

namespace Yarp.ServiceFabric.FabricDiscovery.Topology
{
    internal record DiscoveredApp
    {
        public DiscoveredApp(ApplicationWrapper application)
        {
            this.Application = application ?? throw new ArgumentNullException(nameof(application));
        }

        public ApplicationWrapper Application { get; }
    }
}
