using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerBase(IEnumerable<STToken> enumerable, Boolean debug)
        {
            STContainer containerResult = default;

            var list = new List<STToken>(enumerable);

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
