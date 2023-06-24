using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceFowardPrimarySecondary : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceFowardPrimarySecondary(Int32 size, Int32 volume, Int32 primary, Int32 secondary, Boolean next, Boolean debug)
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

            var total = (primary + difference);

            goto align_INI;

            align_INI:
            {
                var total_ALIGN__INI = total;

                total_ALIGN__INI = total_ALIGN__INI - 1;

                total = total_ALIGN__INI;
            }

            var start = primary;

            var length = total;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceFowardPrimarySecondary()
        {
            return;
        }
    }
}
