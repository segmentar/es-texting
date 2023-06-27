using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer ContainerLastSubset(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var safe_ONE__FIRST = (container.TokenList.Count > 0) is false;

            if (safe_ONE__FIRST is true)
            {
                return containerResult;
            }
            else
                "false".ToString();

            var volume = container.TokenList.Count;

            var last = container.TokenList[volume - 1];

            var array = new STToken[] { last };

            containerResult = MakeContainerBase(array, debug);

            return containerResult;
        }
    }
}
