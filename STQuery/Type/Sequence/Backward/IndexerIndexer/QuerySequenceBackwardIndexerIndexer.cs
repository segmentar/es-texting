using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceBackwardIndexerIndexer : SAInterface.IQuerySequence
    {
        public STSearchReadOnly Immutable { get; set; }

        public STQuerySequenceBackwardIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, indexer_START, indexer_END, next, text, debug);

            var size = symbol.Value.Length;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchBackwardIndexerIndexer(size, volume, indexer_START, indexer_END, next, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            this.Immutable = immutable;

            return;
        }

        ~STQuerySequenceBackwardIndexerIndexer()
        {
            return;
        }
    }
}
