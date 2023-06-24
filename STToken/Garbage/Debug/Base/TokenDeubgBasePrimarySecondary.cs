using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static void Debug_TokenBasePrimarySecondary(SGSymbol symbol, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STToken) + ' ' + "::" + ' ' + nameof(Debug_TokenBasePrimarySecondary) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(primary) + ':' + ' ' + primary,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(secondary) + ':' + ' ' + secondary,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(backward) + ':' + ' ' + backward,
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(skip) + ':' + ' ' + skip,
                        String.Empty + '\t' + '~' + "07" + ' ' + nameof(next) + ':' + ' ' + next,
                        String.Empty + '\t' + '~' + "08" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "09" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(symbol) + ':',
                        String.Empty + symbol,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(text) + ':',
                        String.Empty + text
                    });

                    Console.Out.WriteLine(message);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
