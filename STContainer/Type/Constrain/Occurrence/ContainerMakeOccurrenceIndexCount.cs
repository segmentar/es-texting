using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;

    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerOccurrenceIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerOccurrenceIndexCount(symbol, rebase, index, count, backward, text, debug);

            var list = new List<STToken>();

            var move = false;

            do
            {
                var token = STToken.Runtime_MakeTokenNextIndexCount(symbol, rebase, move, index, count, backward, text);

                if (token.Found is false)
                {
                    break;
                }
                else
                    "false".ToString();

                list.Add(token);

                move = move || true;

                continue;

            } while (true);

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
