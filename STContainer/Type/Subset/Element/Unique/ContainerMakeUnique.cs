using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerUnique(STContainer container, Boolean debug)
        {
            STContainer containerResult = default;

            var list_STATIC = new List<STToken>(container.TokenList);

            var list_DYNAMIC = new List<STToken>(container.TokenList);

            foreach (STToken token_ONE__FIRST in list_STATIC)
            {
                var match_ZERO__TEN_found = false;

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

                    match_ZERO__TEN_found = true;

                    list_DYNAMIC.Remove(token_ONE__FIRST);

                    list_DYNAMIC.Remove(token_TWO__SECOND);

                    continue;
                }

                if (match_ZERO__TEN_found is true)
                {
                    list_DYNAMIC.Add(token_ONE__FIRST);
                }
                else
                    "false".ToString();

                continue;
            }

            containerResult = MakeContainerBase(list_DYNAMIC, debug);

            return containerResult;
        }
    }
}
