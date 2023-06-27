using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_ContainerLastSubset(STContainer container)
        {
            STContainer containerResult = default;

            containerResult = ContainerLastSubset(container, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
