using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {

        static async Task Main(string[] args)
        {
            

            var presentation = new AsyncGenericDelegate();
            await presentation.ActionNowFuncTask(async () => await Task.Run(() => Console.WriteLine("ActionNowFuncTask executed"))
                );
        }

    }
}
