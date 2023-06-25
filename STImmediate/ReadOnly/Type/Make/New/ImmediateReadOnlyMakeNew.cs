using Core;

namespace Core.Shared
{
    using System;

    public partial struct STImmediateReadOnly
    {
        public static STImmediateReadOnly MakeImmediateReadOnlyNew(STImmediate immediate)
        {
            STImmediateReadOnly immutableResult = default;

            immutableResult = new STImmediateReadOnly(
                immediateBefore: immediate.ImmediateBefore,
                immediateAfter: immediate.ImmediateAfter,
                isDebug: immediate.IsDebug
                );

            return immutableResult;
        }
    }
}
