using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerUnique(STContainer container)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerUnique(container, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
