using Core;

namespace Core.Shared
{
    using System;

    public partial class STTokenSequencePrimarySecondary : SAInterface.ITokenSequence
    {
        public STQueryReadOnly Immutable { get; set; }

        public STTokenSequencePrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, primary, secondary, backward, skip, next, text, debug);

            STQuery query;

            if (backward)
            {
                query = STQuery.MakeQueryBackwardPrimarySecondary(symbol, primary, secondary, skip, next, text, debug);
            }
            else
            {
                query = STQuery.MakeQueryForwardPrimarySecondary(symbol, primary, secondary, skip, next, text, debug);
            }

            var immutable = STQueryReadOnly.MakeQueryReadOnlyNew(query);

            this.Immutable = immutable;

            return;
        }

        ~STTokenSequencePrimarySecondary()
        {
            return;
        }
    }
}
