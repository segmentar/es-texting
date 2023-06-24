using Core;

namespace Core.Shared
{
    using System;

    public partial class STTokenSequenceIndexCount : SAInterface.ITokenSequence
    {
        public STQueryReadOnly Immutable { get; set; }

        public STTokenSequenceIndexCount(SGSymbol symbol, Int32 index, Int32 count, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            Debug(symbol, index, count, backward, skip, next, text, debug);

            STQuery query;

            if (backward)
            {
                query = STQuery.MakeQueryBackwardIndexCount(symbol, index, count, skip, next, text, debug);
            }
            else
            {
                query = STQuery.MakeQueryForwardIndexCount(symbol, index, count, skip, next, text, debug);
            }

            var immutable = STQueryReadOnly.MakeQueryReadOnlyNew(query);

            this.Immutable = immutable;

            return;
        }

        ~STTokenSequenceIndexCount()
        {
            return;
        }
    }
}
