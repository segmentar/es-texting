using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerLast(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var safe_ONE__FIRST = (container.TokenList.Count >= 1) is true;

            if (safe_ONE__FIRST is false)
            {
                return containerResult;
            }
            else
                "false".ToString();

            var last = container.TokenList[container.TokenList.Count - 1];

            var list = new List<STToken>();

            list.Add(last);

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
