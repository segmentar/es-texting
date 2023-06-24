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

            foreach (STToken token in list_STATIC)
            {
                var enumerator = list_STATIC.GetEnumerator();

                do
                {
                    if (enumerator.MoveNext() is false)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var current = enumerator.Current;

                    var match_ONE__FIRST = true;

                    match_ONE__FIRST = match_ONE__FIRST && (token == current) is false;

                    match_ONE__FIRST = match_ONE__FIRST && (token.Position == current.Position) is true;

                    if (match_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    list_DYNAMIC.Remove(token);

                    continue;

                } while (true);

                continue;
            }

            containerResult = new STContainer(list_DYNAMIC, debug);

            return containerResult;
        }
    }
}
