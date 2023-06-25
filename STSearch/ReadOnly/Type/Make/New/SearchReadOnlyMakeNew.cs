using Core;

namespace Core.Shared
{
    using System;

    public partial struct STSearchReadOnly
    {
        public static STSearchReadOnly MakeSearchReadOnlyNew(STSearch search)
        {
            STSearchReadOnly immutableResult = default;

            immutableResult = new STSearchReadOnly(
                size: search.Size,
                volume: search.Volume,
                index: search.Index,
                count: search.Count,
                next: search.Next,
                isDebug: search.IsDebug
                );

            return immutableResult;
        }
    }
}
