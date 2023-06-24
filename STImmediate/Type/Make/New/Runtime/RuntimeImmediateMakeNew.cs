using Core;

namespace Core.Shared
{
    using System;

    public partial class STImmediate
    {
        public static STImmediate Runtime_MakeImmediateNew(STToken token, SGDelimiter delimiter)
        {
            STImmediate immediateResult = default;

            immediateResult = MakeImmediateNew(token, delimiter, SAPolicy.ImmediateDebugPolicy);

            return immediateResult;
        }
    }
}
