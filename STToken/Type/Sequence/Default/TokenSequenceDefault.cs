using Core;

namespace Core.Shared
{
    using System;

    public partial class STTokenSequenceDefault : SAInterface.ITokenSequence
    {
        public STQueryReadOnly Immutable { get; set; }

        public STTokenSequenceDefault(SGSymbol symbol, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, backward, skip, next, text, debug);

            STQuery query;

            if (backward)
            {
                query = STQuery.MakeQueryBackwardDefault(symbol, skip, next, text, debug);
            }
            else
            {
                query = STQuery.MakeQueryForwardDefault(symbol, skip, next, text, debug);
            }

            var immutable = STQueryReadOnly.MakeQueryReadOnlyNew(query);

            this.Immutable = immutable;

            return;
        }

        ~STTokenSequenceDefault()
        {
            return;
        }
    }
}
