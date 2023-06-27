using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerOccurrenceDefault(SGSymbol symbol, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            var container = new STContainerOccurrenceSequenceDefault(symbol, rebase, backward, text, debug).Container;

            ArrayList.Add(container);

            containerResult = container;

            return containerResult;
        }
    }
}
