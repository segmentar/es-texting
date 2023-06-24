using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerVariancePrimarySecondary(SGDelimiter delimiter, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerVariancePrimarySecondary(delimiter, rebase, primary, secondary, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                var token = STToken.MakeTokenValuePrimarySecondary(symbol, rebase, primary, secondary, backward, text, debug);

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
