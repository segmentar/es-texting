using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceForwardIndex : SAInterface.IQuerySequence
    {
        public STSearchReadOnly Immutable { get; set; }

        public STQuerySequenceForwardIndex(SGSymbol symbol, Int32 index, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, index, next, text, debug);

            var size = symbol.Value.Length;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardIndex(size, volume, index, next, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            this.Immutable = immutable;

            return;
        }

        ~STQuerySequenceForwardIndex()
        {
            return;
        }
    }
}
