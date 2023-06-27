using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerCollider(STContainer container_VALUE, STContainer container_TERMINATOR, Boolean _front_back_)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back_, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
