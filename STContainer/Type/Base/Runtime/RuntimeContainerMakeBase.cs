using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerBase(IEnumerable<STToken> enumerable)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerBase(enumerable, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
