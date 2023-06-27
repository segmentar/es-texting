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

            var indexer = 0;

            do
            {
                var collider = (largest + 1);

                var safe_ONE__FIRST = (indexer == collider) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                foreach (STToken token in container.TokenList)
                {
                    var safe_TWO__SECOND = (token.Position == indexer) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    list.Add(token);

                    continue;
                }
                
                indexer = indexer + 1;

                continue;

            } while (true);

            containerResult = MakeContainerBase(list, debug);

            return containerResult;
        }
    }
}
