using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    public partial class STSearch
    {
        public STSearch(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            this.Size = size;

            this.Volume = volume;

            this.Index = index;

            this.Count = count;

            this.Next = next;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            if (SAPolicy.SearchInfoPolicy is true)
            {
                SLLogger.Runtime_LoggerDefaultSet(ArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }
    }
}
