using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceForwardIndex : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceForwardIndex(Int32 size, Int32 volume, Int32 index, Boolean next, Boolean debug)
        {
            Debug(size, volume, index, next, debug);

            var difference = (volume - index);

            var start = index;

            var length = difference;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceForwardIndex()
        {
            return;
        }
    }
}
