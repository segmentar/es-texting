using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerManySequenceIndex : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerManySequenceIndex(SGDelimiter delimiter, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, index, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                foreach (STToken token in STContainer.MakeContainerOccurrenceIndex(symbol, rebase, index, backward, text, debug).TokenList)
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

        ~STContainerManySequenceIndex()
        {
            return;
        }
    }
}
