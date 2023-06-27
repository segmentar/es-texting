using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerOccurrenceSequenceDefault : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerOccurrenceSequenceDefault(SGSymbol symbol, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            Debug(symbol, rebase, backward, text, debug);

            var list = new List<STToken>();

            var move = false;

            do
            {
                var token = STToken.Runtime_MakeTokenNextDefault(symbol, rebase, move, backward, text);

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

        ~STContainerOccurrenceSequenceDefault()
        {
            return;
        }
    }
}
