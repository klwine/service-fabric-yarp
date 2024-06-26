﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using Yarp.ServiceFabric.ServiceFabricIntegration;

namespace Yarp.ServiceFabric.FabricDiscovery.Topology
{
    internal record DiscoveredReplica
    {
        public DiscoveredReplica(ReplicaWrapper replica)
        {
            this.Replica = replica ?? throw new ArgumentNullException(nameof(replica));
        }

        public ReplicaWrapper Replica { get; }
    }
}
