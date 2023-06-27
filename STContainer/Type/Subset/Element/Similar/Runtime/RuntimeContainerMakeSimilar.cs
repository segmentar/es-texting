using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerSimilar(STContainer container)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerSimilar(container, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
