using Core;

namespace Core.Shared
{
    using System;

    public partial struct STSearchReadOnly
    {
        public readonly Int32 Size;

        public readonly Int32 Volume;

        public readonly Int32 Index;

        public readonly Int32 Count;

        public readonly Boolean Next;

        public readonly Boolean IsDebug;

        public STSearchReadOnly(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean isDebug)
        {
            this.Size = size;

            this.Volume = volume;

            this.Index = index;

            this.Count = count;

            this.Next = next;

            this.IsDebug = isDebug;

            return;
        }
    }
}
