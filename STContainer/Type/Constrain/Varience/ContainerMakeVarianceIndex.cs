using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerVarianceIndex(SGDelimiter delimiter, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerVarianceIndex(delimiter, rebase, index, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                var token = STToken.MakeTokenValueIndex(symbol, rebase, index, backward, text, debug);

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
