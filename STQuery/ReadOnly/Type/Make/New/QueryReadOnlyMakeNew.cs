using Core;

namespace Core.Shared
{
    using System;

    public partial struct STQueryReadOnly
    {
        public static STQueryReadOnly MakeQueryReadOnlyNew(STQuery query)
        {
            STQueryReadOnly queryResult = default;

            queryResult = new STQueryReadOnly(
                value: query.Value,
                quantity: query.Quantity,
                skip: query.Skip,
                next: query.Next,
                isDebug: query.IsDebug
                );

            return queryResult;
        }
    }
}
