using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceForwardDefault : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceForwardDefault(Int32 size, Int32 volume, Boolean next, Boolean debug)
        {
            Debug(size, volume, next, debug);

            var start = SAConstantVoid.SearchVoid;

            this.Complex = new STSearchComplex(start, volume);

            return;
        }

        ~STSearchSequenceForwardDefault()
        {
            return;
        }
    }
}
