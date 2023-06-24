using Core;

namespace Core.Shared
{
    using System;

    public partial class STTokenSequenceIndex : SAInterface.ITokenSequence
    {
        public STQueryReadOnly Immutable { get; set; }

        public STTokenSequenceIndex(SGSymbol symbol, Int32 index, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, index, backward, skip, next, text, debug);

            STQuery query;

            if (backward)
            {
                query = STQuery.MakeQueryBackwardIndex(symbol, index, skip, next, text, debug);
            }
            else
            {
                query = STQuery.MakeQueryForwardIndex(symbol, index, skip, next, text, debug);
            }

            var immutable = STQueryReadOnly.MakeQueryReadOnlyNew(query);

            this.Immutable = immutable;

            return;
        }

        ~STTokenSequenceIndex()
        {
            return;
        }
    }
}
