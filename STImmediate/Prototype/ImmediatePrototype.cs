using Core;

namespace Core.Shared
{
    using System;

    public partial class STImmediate
    {
        public STImmediate(String immediateBefore, String immediateAfter, Boolean debug)
        {
            this.ImmediateBefore = immediateBefore;

            this.ImmediateAfter = immediateAfter;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
