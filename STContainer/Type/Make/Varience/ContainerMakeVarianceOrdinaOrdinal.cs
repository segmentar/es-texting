using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerVarianceOrdinalOrdinal(SGDelimiter delimiter, Int32 rebase, Int32 ordinal_PRIMARY, Int32 ordinal_SECONDARY, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            var container = new STContainerVarianceSequenceOrdinalOrdinal(delimiter, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, debug).Container;

            ArrayList.Add(container);

            containerResult = container;
            
            return containerResult;
        }
    }
}
