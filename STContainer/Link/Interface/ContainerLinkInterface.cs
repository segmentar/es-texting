using Core;

namespace Core.Shared
{
    using System;

    public partial class SAInterface
    {
        public interface IContainerSequence
        {
            STContainer Container { get; set; }
        }
    }
}
