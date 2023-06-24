using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerOccurrencePrimarySecondary(SGSymbol symbol, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerOccurrencePrimarySecondary(symbol, rebase, primary, secondary, backward, text, debug);

            var list = new List<STToken>();

            var move = false;

            do
            {
                var token = STToken.Runtime_MakeTokenNextPrimarySecondary(symbol, rebase, move, primary, secondary, backward, text);

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
