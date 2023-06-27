using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer ContainerFirstSubset(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var safe_ONE__FIRST = (container.TokenList.Count > 0) is false;

            if (safe_ONE__FIRST is true)
            {
                return containerResult;
            }
            else
                "false".ToString();

            var first = container.TokenList[0];

            var array = new STToken[] { first };

            containerResult = MakeContainerBase(array, debug);

            return containerResult;
        }
    }
}
