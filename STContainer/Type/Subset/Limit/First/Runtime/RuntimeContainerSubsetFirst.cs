using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_ContainerFirstSubset(STContainer container)
        {
            STContainer containerResult = default;

            containerResult = ContainerFirstSubset(container, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
