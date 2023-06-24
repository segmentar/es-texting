using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardIndexerIndexer : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceBackwardIndexerIndexer(Int32 size, Int32 volume, Int32 indexer_START, Int32 indexer_END, Boolean next, Boolean debug)
        {
            Debug(size, volume, indexer_START, indexer_END, next, debug);

            var difference = (indexer_END - indexer_START);

            goto align_ENO;

            align_ENO:
            {
                var difference_ALIGN__ENO = difference;

                difference_ALIGN__ENO = difference_ALIGN__ENO + 1;

                difference = difference_ALIGN__ENO;
            }

            var start = indexer_END;

            var length = difference;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceBackwardIndexerIndexer()
        {
            return;
        }
    }
}
