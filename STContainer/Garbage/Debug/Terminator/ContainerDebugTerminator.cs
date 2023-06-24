using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static void Debug_ContainerTerminator(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + nameof(Debug_ContainerTerminator) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(delimiter_VALUE) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(delimiter_TERMINATOR) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(_front_back__ANSWER_BOOLEAN__) + ':' + ' ' + _front_back__ANSWER_BOOLEAN__,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(backward) + ':' + ' ' + backward,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(delimiter_VALUE) + ':',
                        String.Empty + delimiter_VALUE,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(delimiter_TERMINATOR) + ':',
                        String.Empty + delimiter_TERMINATOR,
                        String.Empty,
                        String.Empty + '~' + "30" + ' ' + nameof(text) + ':',
                        String.Empty + text
                    });
                }
                else
                    "false".ToString();

                return;
            }
        }
    }
}
