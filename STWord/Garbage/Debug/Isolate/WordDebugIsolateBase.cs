using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static void Debug_WordIsolateBase(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STWord) + ' ' + "::" + ' ' + nameof(Debug_WordIsolateBase) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(index) + ':' + ' ' + index,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(count) + ':' + ' ' + count,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(text) + ':',
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
