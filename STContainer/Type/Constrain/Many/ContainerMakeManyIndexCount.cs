using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerManyIndexCount(Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, SGDelimiter delimiter, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerManyIndexCount(rebase, index, count, backward, text, delimiter, debug);

            /*foreach (String symbol_VALUE in delimiter.DelimiterArray)
            {
                var symbol = new SGSymbol(symbol_VALUE);

                foreach (SToken token in MakeTokenOccurrenceIndexCount(symbol, rebase, index, count, backward, text, debug))
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
