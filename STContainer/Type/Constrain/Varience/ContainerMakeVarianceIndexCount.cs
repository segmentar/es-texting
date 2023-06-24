using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerVarianceIndexCount(SGDelimiter delimiter, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerVarianceIndexCount(delimiter, rebase, index, count, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                var token = STToken.MakeTokenValueIndexCount(symbol, rebase, index, count, backward, text, debug);

                if (token.Found is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                list.Add(token);

                break;
            }

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
