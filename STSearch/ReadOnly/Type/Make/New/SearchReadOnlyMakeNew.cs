using Core;

namespace Core.Shared
{
    using System;

    public partial struct STSearchReadOnly
    {
        public static STSearchReadOnly MakeSearchReadOnlyNew(STSearch search)
        {
            STSearchReadOnly searchResult = default;

            searchResult = new STSearchReadOnly(
                size: search.Size,
                volume: search.Volume,
                index: search.Index,
                count: search.Count,
                next: search.Next,
                isDebug: search.IsDebug
                );

            return searchResult;
        }
    }
}
