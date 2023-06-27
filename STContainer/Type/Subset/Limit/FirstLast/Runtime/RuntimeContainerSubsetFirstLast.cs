using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_ContainerFirstLastSubset(STContainer container, Boolean _first_last_)
        {
            STContainer containerResult = default;

            containerResult = ContainerFirstLastSubset(container, _first_last_, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
