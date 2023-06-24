using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STImmediate
    {
        public static STImmediate MakeImmediateNew(STToken token, SGDelimiter delimiter, Boolean debug)
        {
            STImmediate immediateResult = default;

            var volume = delimiter.Text.Value.Length;

            var start = token.Position;

            var length = token.Symbol.Value.Length;

            var total = (start + length);

            var difference = (volume - total);

            var sub_BEFORE = delimiter.Text.Value.Substring(0, token.Position);

            var sub_AFTER = delimiter.Text.Value.Substring(total, difference);

            var before = String.Empty;

            var after = String.Empty;

            var indexer_BEFORE = (sub_BEFORE.Length - 1);

            do
            {
                var safe_ONE__FIRST = (indexer_BEFORE == 0) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var character = sub_BEFORE[indexer_BEFORE];

                foreach (SGSymbol symbol in delimiter.DelimiterCharacterList)
                {
                    var safe_TWO__SECOND = (character == symbol.Value[0]) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    goto before_BREAK;
                }

                before = before + character;

                indexer_BEFORE = indexer_BEFORE - 1;

                continue;

                before_BREAK:
                {
                    break;
                }

            } while (true);

            var indexer_AFTER = 0;

            do
            {
                var safe_ONE__FIRST = (indexer_AFTER == sub_AFTER.Length) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var character = sub_AFTER[indexer_AFTER];

                foreach (SGSymbol symbol in delimiter.DelimiterCharacterList)
                {
                    var safe_TWO__SECOND = (character == symbol.Value[0]) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    goto after_BREAK;
                }

                after = after + character;

                indexer_AFTER = indexer_AFTER + 1;

                continue;

                after_BREAK:
                {
                    break;
                }

            } while (true);

            var before_DATA = before.ToCharArray();

            var after_DATA = after.ToCharArray();

            Array.Reverse(before_DATA);

            var immediateBefore = new String(before_DATA, 0, before_DATA.Length);

            var immediateAfter = new String(after_DATA, 0, after_DATA.Length);

            immediateResult = new STImmediate(immediateBefore, immediateAfter, debug);

            return immediateResult;
        }
    }
}
