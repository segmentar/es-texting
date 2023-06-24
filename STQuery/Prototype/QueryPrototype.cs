using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public STQuery(Int32 value, Int32 quantity, Boolean skip, Boolean next, Boolean debug)
        {
            this.Value = value;

            this.Quantity = quantity;

            this.Skip = skip;

            this.Next = next;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            if (SAPolicy.QueryInfoPolicy is true)
            {
                SLLogger.Runtime_LoggerDefaultSet(ArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }
    }
}
