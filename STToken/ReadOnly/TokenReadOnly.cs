using Core;

namespace Core.Shared
{
    using System;

    public partial struct STTokenReadOnly
    {
        public SGSymbol Symbol;

        public Int32 Position;

        public Int32 Quantity;

        public Boolean Found;

        public Boolean IsDebug;

        public STTokenReadOnly(SGSymbol symbol, Int32 position, Int32 quantity, Boolean found, Boolean isDebug)
        {
            this.Symbol = symbol;

            this.Position = position;

            this.Quantity = quantity;

            this.Found = found;

            this.IsDebug = isDebug;

            return;
        }
    }
}
