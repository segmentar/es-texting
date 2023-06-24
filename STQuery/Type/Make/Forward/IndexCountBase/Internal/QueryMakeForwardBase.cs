using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryForwardBase(SGSymbol symbol, Int32 index, Int32 count, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            char[] data = text.Value.ToCharArray();

            int i, j, n, m, x, o;

            i = index;

            n = count;

            m = symbol.Value.Length;

            x = (i + n);

            char ci, ic, cj, jc;

            var quantity = 1;

            var match_ZERO__TEN_found_strong = false;

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

                ic = symbol.Value[0];

                var match_ONE__FIRST = (ci == ic) is true;

                if (match_ONE__FIRST is true)
                {
                    match_ZERO__TEN_found_strong = true;

                    for (j = i; ;)
                    {
                        o = (j - i);

                        var safe_TWO__SECOND = false;

                        safe_TWO__SECOND = safe_TWO__SECOND || (j == x) is true;

                        safe_TWO__SECOND = safe_TWO__SECOND || (o == m) is true;

                        if (safe_TWO__SECOND is true)
                        {
                            if (o == m)
                            {
                                match_ZERO__TEN_found_strong = true;
                            }
                            else
                            {
                                match_ZERO__TEN_found_strong = false;
                            }

                            break;
                        }
                        else
                            "false".ToString();

                        cj = data[j];

                        jc = symbol.Value[o];

                        var safe_THREE__THIRD = (cj == jc) is false;

                        if (safe_THREE__THIRD is true)
                        {
                            match_ZERO__TEN_found_strong = false;

                            break;
                        }
                        else
                            "false".ToString();

                        j = j + 1;

                        continue;
                    }
                }
                else
                    "false".ToString();

                if (match_ZERO__TEN_found_strong && skip is false)
                {
                    break;
                }
                else if (match_ZERO__TEN_found_strong && skip is true)
                {
                    match_ZERO__TEN_found_strong = false;

                    queryResult = new STQuery(i, quantity, skip, next, debug);

                    quantity = quantity + 1;
                }

                i = i + 1;

                continue;
            }

            var match_ZERO__TEN_found_weak = (queryResult == default) is false;

            if (match_ZERO__TEN_found_strong)
            {
                queryResult = new STQuery(i, quantity, skip, next, debug);
            }
            else if (match_ZERO__TEN_found_weak is true)
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
