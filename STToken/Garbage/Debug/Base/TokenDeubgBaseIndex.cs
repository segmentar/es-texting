﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static void Debug_TokenBaseIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STToken) + ' ' + "::" + ' ' + nameof(Debug_TokenBaseIndex) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(index) + ':' + ' ' + index,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(backward) + ':' + ' ' + backward,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(skip) + ':' + ' ' + skip,
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(next) + ':' + ' ' + next,
                        String.Empty + '\t' + '~' + "07" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "08" + ' ' + nameof(debug) + ':' + ' ' + debug,
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
