using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerCollider(STContainer container_VALUE, STContainer container_TERMINATOR, Boolean _largest_smallest__ANSWER_BOOLEAN__)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerCollider(container_VALUE, container_TERMINATOR, _largest_smallest__ANSWER_BOOLEAN__, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
