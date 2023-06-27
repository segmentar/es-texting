using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerOccurrenceSequenceIndex : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerOccurrenceSequenceIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            Debug(symbol, rebase, index, backward, text, debug);

            var list = new List<STToken>();

            var move = false;

            do
            {
                var token = STToken.Runtime_MakeTokenNextIndex(symbol, rebase, move, index, backward, text);

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

            var container = STContainer.MakeContainerBase(list, debug);

            this.Container = container;

            return;
        }

        ~STContainerOccurrenceSequenceIndex()
        {
            return;
        }
    }
}
