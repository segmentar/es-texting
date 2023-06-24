using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryBackwardBase(SGSymbol symbol, Int32 index, Int32 count, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__ = index;

            var count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__ = count;

            var start = start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__;

            var length = count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__;

            char[] data = text.Value.ToCharArray();

            int i, j, n, m, x, o, k, l, ijnmxokl = -1;

            i = start;

            n = length;

            m = symbol.Value.Length;

            x = (i - n);

            k = (m - 1);

            char ci, ic, cj, jc;

            var quantity = 1;

            var found = false;

            for (; ; )
            {
                var safe_ONE__FIRST = false;

                safe_ONE__FIRST = safe_ONE__FIRST || (i == x) is true;

                safe_ONE__FIRST = safe_ONE__FIRST || (i < 0) is true;

                safe_ONE__FIRST = safe_ONE__FIRST || (n < 0) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                ci = data[i];

                ic = symbol.Value[k];

                var match_ONE__FIRST = (ci == ic) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                if (match_ONE__FIRST is true)
                {
                    found = true;

                    for (j = i; ;)
                    {
                        o = (i - j);

                        l = (k - o);

                        ijnmxokl = (j + 1);

                        var safe_TWO__SECOND = false;

                        safe_TWO__SECOND = safe_TWO__SECOND || (j == x) is true;

                        safe_TWO__SECOND = safe_TWO__SECOND || (o == m) is true;

                        if (safe_TWO__SECOND is true)
                        {
                            if (o == m)
                            {
                                found = true;
                            }
                            else
                            {
                                found = false;
                            }

                            break;
                        }
                        else
                            "false".ToString();

                        cj = data[j];

                        jc = symbol.Value[l];

                        var match_TWO__SECOND = (cj == jc) is false;

                        if (match_TWO__SECOND is true)
                        {
                            found = false;

                            break;
                        }
                        else
                            "false".ToString();

                        j = j - 1;

                        continue;
                    }
                }
                else
                    "false".ToString();

                if (found && skip is false)
                {
                    break;
                }
                else if (found && skip is true)
                {
                    found = false;

                    queryResult = new STQuery(ijnmxokl, quantity, skip, next, debug);

                    quantity = quantity + 1;
                }

                i = i - 1;

                continue;
            }

            if (found)
            {
                queryResult = new STQuery(ijnmxokl, quantity, skip, next, debug);
            }
            else if ((queryResult == default) is false)
            {
                return queryResult;
            }
            else
            {
                queryResult = new STQuery(SAConstantUnsuccess.QueryUnsuccess, SAConstantVoid.QueryQuantityDefault, skip, next, debug);
            }

            return queryResult;
        }
    }
}
