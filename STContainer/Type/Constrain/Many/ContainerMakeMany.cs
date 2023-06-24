using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerMany(SGDelimiter delimiter, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerMany(delimiter, rebase, backward, text, debug);

            var list = new List<STToken>();

            foreach (STToken token in Runtime_MakeContainerVariance(delimiter, rebase, backward, text).TokenList)
            {
                var enumerator = Runtime_MakeContainerOccurrence(token.Symbol, 0, backward, text).TokenList.GetEnumerator();

                do
                {
                    if (enumerator.MoveNext() is false)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var current = enumerator.Current;

                    list.Add(current);

                    continue;

                } while (true);

                continue;
            }

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
