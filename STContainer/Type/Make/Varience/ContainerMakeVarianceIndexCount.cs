using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerVarianceIndexCount(SGDelimiter delimiter, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            var container = new STContainerVarianceSequenceIndexCount(delimiter, rebase, index, count, backward, text, debug).Container;

            ArrayList.Add(container);

            containerResult = container;

            return containerResult;
        }
    }
}
