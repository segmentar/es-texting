﻿using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerLast(STContainer container)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerLast(container, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
