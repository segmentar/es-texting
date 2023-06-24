using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerSort(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var largest = 0;

            foreach (STToken token in container.TokenList)
            {
                var safe_match_ONE__FIRST = (token.Position > largest) is false;

                if (safe_match_ONE__FIRST is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                largest = token.Position;

                continue;
            }

            var list = new List<STToken>();

            var ini = 0;

            do
            {
                var collider = (largest + 1);

                var safe_ONE__FIRST = (ini == collider) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                foreach (STToken token in container.TokenList)
                {
                    var safe_match_ONE__FIRST = (token.Position == ini) is true;

                    if (safe_match_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    list.Add(token);

                    continue;
                }
                
                ini = ini + 1;

                continue;

            } while (true);

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
