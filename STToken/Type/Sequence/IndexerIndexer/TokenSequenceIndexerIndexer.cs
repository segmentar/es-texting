using Core;

namespace Core.Shared
{
    using System;

    public partial class STTokenSequenceIndexerIndexer : SAInterface.ITokenSequence
    {
        public STQueryReadOnly Immutable { get; set; }

        public STTokenSequenceIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, indexer_START, indexer_END, backward, skip, next, text, debug);

            STQuery query;

            if (backward)
            {
                query = STQuery.MakeQueryBackwardIndexerIndexer(symbol, indexer_START, indexer_END, skip, next, text, debug);
            }
            else
            {
                query = STQuery.MakeQueryForwardIndexerIndexer(symbol, indexer_START, indexer_END, skip, next, text, debug);
            }

            var immutable = STQueryReadOnly.MakeQueryReadOnlyNew(query);

            this.Immutable = immutable;

            return;
        }

        ~STTokenSequenceIndexerIndexer()
        {
            return;
        }
    }
}
