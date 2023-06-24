using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STImmediate
    {
        public static IList<STImmediate> ImmediateDefaultSet(IEnumerable<STToken> enumerable, SGDelimiter delimiter)
        {
            ICollection<STImmediate> collectionResult = default;

            collectionResult = new Collection<STImmediate>();

            foreach (STToken token in enumerable)
            {
                var immediate = Runtime_MakeImmediateNew(token, delimiter);

                collectionResult.Add(immediate);

                continue;
            }

            return new List<STImmediate>(collectionResult);
        }
    }
}
