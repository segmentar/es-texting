using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerSort(STContainer container)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerSort(container, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
