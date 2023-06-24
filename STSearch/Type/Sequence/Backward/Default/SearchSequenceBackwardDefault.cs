using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardDefault : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceBackwardDefault(Int32 size, Int32 volume, Boolean next, Boolean debug)
        {
            Debug(size, volume, next, debug);

            goto align_INI;

            align_INI:
            {
                var volume_ALIGN__INI = volume;

                volume_ALIGN__INI = volume_ALIGN__INI - 1;

                volume = volume_ALIGN__INI;
            }

            var start = volume;

            this.Complex = new STSearchComplex(start, volume);

            return;
        }

        ~STSearchSequenceBackwardDefault()
        {
            return;
        }
    }
}
