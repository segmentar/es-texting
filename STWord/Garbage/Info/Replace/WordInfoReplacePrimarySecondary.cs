using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static void Info_WordReplacePrimarySecondary(STSearch search, Int32 start, Int32 length, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (SAPolicy.WordInfoPolicy is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STWord) + ' ' + "::" + ' ' + nameof(Info_WordReplacePrimarySecondary) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + nameof(search) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + nameof(start) + ':' + ' ' + start,
                        String.Empty + '\t' + '~' + "03" + nameof(length) + ':' + ' ' + length,
                        String.Empty + '\t' + '~' + "04" + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + '~' + nameof(search) + ':',
                        String.Empty + search
                    });

                    ArrayList.Add(message);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
