using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryBackwardBase(SGSymbol symbol, Int32 index, Int32 count, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            char[] data = text.Value.ToCharArray();

            int i, j, n, m, x, o, k, l, ijnmxokl = -1;

            i = index;

            n = count;

            m = symbol.Value.Length;

            x = (i - n);

            k = (m - 1);

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

                ic = symbol.Value[k];

                var match_ONE__FIRST = (ci == ic) is true;

                if (match_ONE__FIRST is true)
                {
                    match_ZERO__TEN_found_strong = true;

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

                        jc = symbol.Value[l];

                        var safe_THREE__THIRD = (cj == jc) is false;

                        if (safe_THREE__THIRD is true)
                        {
                            match_ZERO__TEN_found_strong = false;

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

                var match_ZERO__TEN_found_break = true;

                match_ZERO__TEN_found_break = match_ZERO__TEN_found_break && skip is false;

                match_ZERO__TEN_found_break = match_ZERO__TEN_found_break && match_ZERO__TEN_found_strong is true;

                var match_ZERO__TEN_found_continue = true;

                match_ZERO__TEN_found_continue = match_ZERO__TEN_found_continue && skip is true;

                match_ZERO__TEN_found_continue = match_ZERO__TEN_found_continue && match_ZERO__TEN_found_strong is true;

                if (match_ZERO__TEN_found_break is true)
                {
                    break;
                }
                else if (match_ZERO__TEN_found_continue is true)
                {
                    match_ZERO__TEN_found_strong = false;

                    queryResult = new STQuery(ijnmxokl, quantity, skip, next, debug);

                    quantity = quantity + 1;
                }

                i = i - 1;

                continue;
            }

            var match_ZERO__TEN_found_weak = (queryResult == default) is false;

            if (match_ZERO__TEN_found_strong)
            {
                queryResult = new STQuery(ijnmxokl, quantity, skip, next, debug);
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
