using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerColliderBackward(STContainer container_VALUE, STContainer container_TERMINATOR, Boolean debug)
        {
            STContainer containerResult = default;

            var largest = 0;

            foreach (STToken token in container_TERMINATOR.TokenList)
            {
                var safe_match__ONE_FIRST = (token.Position > largest) is true;

                if (safe_match__ONE_FIRST is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                largest = token.Position;

                continue;
            }

            var smallest = largest;

            foreach (STToken token in container_TERMINATOR.TokenList)
            {
                var safe_match__ONE_FIRST = (token.Position < smallest) is true;

                if (safe_match__ONE_FIRST is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                smallest = token.Position;

                continue;
            }

            var list = new List<STToken>();

            foreach (STToken token in container_VALUE.TokenList)
            {
                var safe_match__ONE_FIRST = (token.Position > largest) is true;

                if (safe_match__ONE_FIRST is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                list.Add(token);
                
                continue;
            }

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
