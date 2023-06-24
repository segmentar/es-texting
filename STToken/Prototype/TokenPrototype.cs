using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public STToken(SGSymbol symbol, Int32 position, Int32 quantity, Boolean found, Boolean debug)
        {
            this.Symbol = symbol;

            this.Position = position;

            this.Quantity = quantity;

            this.Found = found;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            if (SAPolicy.TokenInfoPolicy is true)
            {
                SLLogger.Runtime_LoggerDefaultSet(ArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }
    }
}
