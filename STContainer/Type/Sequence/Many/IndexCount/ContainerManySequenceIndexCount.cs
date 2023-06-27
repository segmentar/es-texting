using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerManySequenceIndexCount : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerManySequenceIndexCount(SGDelimiter delimiter, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, index, count, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                foreach (STToken token in STContainer.MakeContainerOccurrenceIndexCount(symbol, rebase, index, count, backward, text, debug).TokenList)
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

        ~STContainerManySequenceIndexCount()
        {
            return;
        }
    }
}
