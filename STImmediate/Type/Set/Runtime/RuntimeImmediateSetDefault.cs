using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STImmediate
    {
        public static STImmediate[] Runtime_ImmediateDefaultSet(IEnumerable<STToken> enumerable, SGDelimiter delimiter)
        {
            STImmediate[] arrayResult = default;

            var list = new List<STImmediate>(ImmediateDefaultSet(enumerable, delimiter));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
