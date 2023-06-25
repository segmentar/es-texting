using Core;

namespace Core.Shared
{
    using System;

    public partial struct STImmediateReadOnly
    {
        public readonly String ImmediateBefore;

        public readonly String ImmediateAfter;

        public readonly Boolean IsDebug;

        public STImmediateReadOnly(String immediateBefore, String immediateAfter, Boolean isDebug)
        {
            this.ImmediateBefore = immediateBefore;

            this.ImmediateAfter = immediateAfter;

            this.IsDebug = isDebug;

            return;
        }
    }
}
