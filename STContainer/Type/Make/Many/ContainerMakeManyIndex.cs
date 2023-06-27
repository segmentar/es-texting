using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerManyIndex(SGDelimiter delimiter, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            var container = new STContainerManySequenceIndex(delimiter, rebase, index, backward, text, debug).Container;

            ArrayList.Add(container);

            containerResult = container;

            return containerResult;
        }
    }
}
