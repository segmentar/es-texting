using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceForwardIndexCount : SAInterface.IQuerySequence
    {
        public STSearchReadOnly Immutable { get; set; }

        public STQuerySequenceForwardIndexCount(SGSymbol symbol, Int32 index, Int32 count, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, index, count, next, text, debug);

            var size = symbol.Value.Length;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardIndexCount(size, volume, index, count, next, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            this.Immutable = immutable;

            return;
        }

        ~STQuerySequenceForwardIndexCount()
        {
            return;
        }
    }
}
