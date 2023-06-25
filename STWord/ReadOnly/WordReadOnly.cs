using Core;

namespace Core.Shared
{
    using System;

    public partial struct STWordReadOnly
    {
        public readonly String WordBefore;

        public readonly String WordAfter;

        public readonly Boolean IsDebug;

        public STWordReadOnly(String wordBefore, String wordAfter, Boolean isDebug)
        {
            this.WordBefore = wordBefore;

            this.WordAfter = wordAfter;

            this.IsDebug = isDebug;

            return;
        }
    }
}
