using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public STWord(String wordBefore, String wordAfter, Boolean debug)
        {
            this.WordBefore = wordBefore;

            this.WordAfter = wordAfter;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            if (SAPolicy.WordInfoPolicy is true)
            {
                SLLogger.Runtime_LoggerDefaultSet(ArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }
    }
}
