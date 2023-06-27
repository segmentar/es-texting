using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerVarianceSequenceOrdinalOrdinal : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerVarianceSequenceOrdinalOrdinal(SGDelimiter delimiter, Int32 rebase, Int32 ordinal_PRIMARY, Int32 ordinal_SECONDARY, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                var token = STToken.MakeTokenValuePrimarySecondary(symbol, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, debug);

                if (token.Found is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                list.Add(token);

                break;
            }

            var container = STContainer.MakeContainerBase(list, debug);

            this.Container = container;

            return;
        }

        ~STContainerVarianceSequenceOrdinalOrdinal()
        {
            return;
        }
    }
}
