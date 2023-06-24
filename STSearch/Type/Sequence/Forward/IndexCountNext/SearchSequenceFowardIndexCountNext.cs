using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceFowardIndexCountNext : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceFowardIndexCountNext(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            Debug(size, volume, index, count, next, debug);

            var total = (index + size);

            var difference_LEFT = (volume - total);

            var difference_RIGHT = (count - size);

            var difference = (difference_LEFT + difference_RIGHT);

            goto align_DIVIDE;

            align_DIVIDE:
            {
                var difference_ALIGN__DIVIDE = difference;

                difference_ALIGN__DIVIDE = difference_ALIGN__DIVIDE / 2;

                difference = difference_ALIGN__DIVIDE;
            }

            var start = total;

            var length = difference;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceFowardIndexCountNext()
        {
            return;
        }
    }
}
