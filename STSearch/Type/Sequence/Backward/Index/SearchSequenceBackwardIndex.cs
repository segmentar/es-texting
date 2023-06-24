using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardIndex : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceBackwardIndex(Int32 size, Int32 volume, Int32 index, Boolean next, Boolean debug)
        {
            Debug(size, volume, index, next, debug);

            var start = index;

            var length = index;

            goto align_ENO;

            align_ENO:
            {
                var length_ALIGN__ENO = length;

                length_ALIGN__ENO = length_ALIGN__ENO + 1;

                length = length_ALIGN__ENO;
            }

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceBackwardIndex()
        {
            return;
        }
    }
}
