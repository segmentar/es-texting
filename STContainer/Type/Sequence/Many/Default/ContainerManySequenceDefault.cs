using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerManySequenceDefault : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerManySequenceDefault(SGDelimiter delimiter, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                foreach (STToken token in STContainer.MakeContainerOccurrenceDefault(symbol, rebase, backward, text, debug).TokenList)
                {
                    list.Add(token);

                    continue;
                }

                continue;
            }

            var container = STContainer.MakeContainerBase(list, debug);

            this.Container = container;

            return;
        }

        ~STContainerManySequenceDefault()
        {
            return;
        }
    }
}
