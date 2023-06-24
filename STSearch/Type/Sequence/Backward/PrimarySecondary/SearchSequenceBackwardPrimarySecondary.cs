using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardPrimarySecondary : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceBackwardPrimarySecondary(Int32 size, Int32 volume, Int32 primary, Int32 secondary, Boolean next, Boolean debug)
        {
            Debug(size, volume, primary, secondary, next, debug);

            goto align_PRIMARY__INI;

            align_PRIMARY__INI:
            {
                var primary_ALIGN__INI = primary;

                primary_ALIGN__INI = primary_ALIGN__INI - 1;

                primary = primary_ALIGN__INI;
            }

            goto align_SECONDARY__INI;

            align_SECONDARY__INI:
            {
                var secondary_ALIGN__INI = secondary;

                secondary_ALIGN__INI = secondary_ALIGN__INI - 1;

                secondary = secondary_ALIGN__INI;
            }

            var difference = (secondary - primary);

            goto align_INI;

            align_INI:
            {
                var difference_ALIGN__INI = difference;

                difference_ALIGN__INI = difference_ALIGN__INI - 1;

                difference = difference_ALIGN__INI;
            }

            var total = (primary + difference);

            var start = secondary;

            var length = total;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceBackwardPrimarySecondary()
        {
            return;
        }
    }
}
