using Core;

namespace Core.Shared
{
    using System;

    public partial struct STQueryReadOnly
    {
        public readonly Int32 Value;

        public readonly Int32 Quantity;

        public readonly Boolean Skip;

        public readonly Boolean Next;

        public readonly Boolean IsDebug;

        public STQueryReadOnly(Int32 value, Int32 quantity, Boolean skip, Boolean next, Boolean isDebug)
        {
            this.Value = value;

            this.Quantity = quantity;

            this.Skip = skip;

            this.Next = next;

            this.IsDebug = isDebug;

            return;
        }
    }
}
