using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerManyPrimarySecondary(Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text, SGDelimiter delimiter, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerManyPrimarySecondary(rebase, primary, secondary, backward, text, delimiter, debug);
            /*foreach (String symbol_VALUE in delimiter.DelimiterArray)
            {
                var symbol = new SGSymbol(symbol_VALUE);

                foreach (SToken token in MakeTokenOccurrencePrimarySecondary(symbol, rebase, primary, secondary, backward, text, debug))
                {
                    collectionResult.Add(token);

                    continue;
                }

                continue;
            }*/

            return containerResult;
        }
    }
}
