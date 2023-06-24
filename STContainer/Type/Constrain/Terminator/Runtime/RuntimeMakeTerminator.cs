using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerTerminator(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Int32 rebase, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerTerminator(delimiter_VALUE, delimiter_TERMINATOR, _front_back__ANSWER_BOOLEAN__, rebase, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
