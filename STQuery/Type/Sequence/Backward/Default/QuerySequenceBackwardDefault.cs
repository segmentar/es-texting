using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceBackwardDefault : SAInterface.IQuerySequence
    {
        public STSearchReadOnly Immutable { get; set; }

        public STQuerySequenceBackwardDefault(SGSymbol symbol, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, next, text, debug);

            var size = symbol.Value.Length;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchBackwardDefault(size, volume, next, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            this.Immutable = immutable;

            return;
        }

        ~STQuerySequenceBackwardDefault()
        {
            return;
        }
    }
}
