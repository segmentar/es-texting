using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerFirstLast(STContainer container, Boolean _first_last__ANSWER__BOOLEAN__)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerFirstLast(container, _first_last__ANSWER__BOOLEAN__, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
