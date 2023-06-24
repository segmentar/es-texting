using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerFirst(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var safe_ONE__FIRST = (container.TokenList.Count >= 1) is true;

            if (safe_ONE__FIRST is false)
            {
                return containerResult;
            }
            else
                "false".ToString();

            var first = container.TokenList[0];

            var list = new List<STToken>();

            list.Add(first);

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
