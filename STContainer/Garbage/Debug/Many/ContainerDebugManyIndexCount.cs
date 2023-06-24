using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static void Debug_ContainerManyIndexCount(Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, SGDelimiter delimiter, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + nameof(Debug_ContainerManyIndexCount) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(delimiter) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(index) + ':' + ' ' + index,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(count) + ':' + ' ' + count, 
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(backward) + ':' + ' ' + backward,
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "07" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(delimiter) + ':',
                        String.Empty + delimiter,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(text) + ':',
                        String.Empty + text
                    });
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
