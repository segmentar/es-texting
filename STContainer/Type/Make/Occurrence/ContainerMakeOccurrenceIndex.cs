using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;

    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerOccurrenceIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            var container = new STContainerOccurrenceSequenceIndex(symbol, rebase, index, backward, text, debug).Container;

            ArrayList.Add(container);

            containerResult = container;

            return containerResult;
        }
    }
}
