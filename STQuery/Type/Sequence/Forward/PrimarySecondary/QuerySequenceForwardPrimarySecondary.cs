using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceForwardPrimarySecondary : SAInterface.IQuerySequence
    {
        public STSearchReadOnly Immutable { get; set; }

        public STQuerySequenceForwardPrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, primary, secondary, next, text, debug);

            var size = symbol.Value.Length;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardPrimarySecondary(size, volume, primary, secondary, next, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            this.Immutable = immutable;

            return;
        }

        ~STQuerySequenceForwardPrimarySecondary()
        {
            return;
        }
    }
}
