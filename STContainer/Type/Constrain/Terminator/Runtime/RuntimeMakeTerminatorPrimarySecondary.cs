using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerTerminatorPrimarySecondary(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerTerminatorPrimarySecondary(delimiter_VALUE, delimiter_TERMINATOR, _front_back__ANSWER_BOOLEAN__, rebase, primary, secondary, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
