using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordInsertIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordInsertIndexerIndexer(symbol, indexer_START, indexer_END, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
