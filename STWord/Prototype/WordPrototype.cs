using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public STWord(String symbol_BEFORE, String symbol_AFTER, Boolean debug)
        {
            this.Before = symbol_BEFORE;

            this.After = symbol_AFTER;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            if (SAPolicy.WordInfoPolicy is true)
            {
                foreach (Object item in ArrayList)
                {
                    Console.Out.WriteLine(item);

                    continue;
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
