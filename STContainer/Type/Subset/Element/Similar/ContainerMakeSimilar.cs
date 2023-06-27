using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerSimilar(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var list_STATIC = new List<STToken>(container.TokenList);

            var list_SIMILAR = new List<STToken>();

            foreach (STToken token_ONE__FIRST in list_STATIC)
            {
                foreach (STToken token_TWO__SECOND in list_STATIC)
                {
                    var safe_ONE__FIRST = true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (token_ONE__FIRST == token_TWO__SECOND) is false;

                    safe_ONE__FIRST = safe_ONE__FIRST && (token_ONE__FIRST.Position == token_TWO__SECOND.Position) is true;

                    if (safe_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    list_SIMILAR.Add(token_ONE__FIRST);

                    list_SIMILAR.Add(token_TWO__SECOND);

                    continue;
                }

                continue;
            }

            containerResult = MakeContainerBase(list_SIMILAR, debug);

            return containerResult;
        }
    }
}
