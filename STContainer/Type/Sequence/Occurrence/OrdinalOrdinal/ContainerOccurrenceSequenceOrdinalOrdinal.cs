using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerOccurrenceSequenceOrdinalOrdinal : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerOccurrenceSequenceOrdinalOrdinal(SGSymbol symbol, Int32 rebase, Int32 ordinal_PRIMARY, Int32 ordinal_SECONDARY, Boolean backward, SGText text, Boolean debug)
        {
            Debug(symbol, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, debug);

            var list = new List<STToken>();

            var move = false;

            do
            {
                var token = STToken.Runtime_MakeTokenNextPrimarySecondary(symbol, rebase, move, ordinal_PRIMARY, ordinal_SECONDARY, backward, text);

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

        ~STContainerOccurrenceSequenceOrdinalOrdinal()
        {
            return;
        }
    }
}
