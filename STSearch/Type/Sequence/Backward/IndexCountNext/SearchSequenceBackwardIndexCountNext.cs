using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardIndexCountNext : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceBackwardIndexCountNext(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            Debug(size, volume, index, count, next, debug);

            var total = (index - size);

            var repeat_LEFT = (total + 1);

            var repeat_RIGHT = (count - size);

            var repeat = (repeat_LEFT + repeat_RIGHT);

            goto align_DIVIDE;

            align_DIVIDE:
            {
                var repeat_ALIGN__DIVIDE = repeat;

                repeat_ALIGN__DIVIDE = repeat_ALIGN__DIVIDE / 2;

                repeat = repeat_ALIGN__DIVIDE;
            }

            var start = total;

            var length = repeat;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceBackwardIndexCountNext()
        {
            return;
        }
    }
}
