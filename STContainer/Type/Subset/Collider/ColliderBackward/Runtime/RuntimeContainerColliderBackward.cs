using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerColliderBackward(STContainer container_VALUE, STContainer container_TERMINATOR)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerColliderForward(container_VALUE, container_TERMINATOR, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
