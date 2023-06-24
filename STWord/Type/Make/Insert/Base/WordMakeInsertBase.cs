using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord MakeWordInsertBase(SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            Debug_WordInsertBase(symbol, index, count, text, debug);

            var volume_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two = text.Value.Length;

            var start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__thirty_two = index;

            var count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two = count;

            var volume = volume_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two;

            var start = start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__thirty_two;

            var length = count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two;

            var total = (start + length);

            var difference = (volume - total);

            var sub_START = text.Value.Substring(0, start);

            var sub_MIDDLE = symbol.Value.Substring(0, length);

            var sub_END = text.Value.Substring(total, difference);

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            wordResult = new STWord(text_BEFORE, text_AFTER, debug);

            return wordResult;
        }
    }
}
