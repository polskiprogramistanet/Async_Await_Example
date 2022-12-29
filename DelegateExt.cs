using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwaitExample
{
    public delegate int Operation(int x);
    public class DelegateExt
    {
        public Operation Operation { get; set; }
    }
}
