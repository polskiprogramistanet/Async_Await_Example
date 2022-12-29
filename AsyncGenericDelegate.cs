using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    public class AsyncGenericDelegate
    {
        public async Task ActionNowFuncTask(Func<Task> task)
        {
            await task();
        }

        public async Task ActionWithParameterNowFuncParameterAndTask(Func<string, Task> task)
        {
            await task(arg: "Action With Parameter Now Func Parameter And Task Executed");
        }

        public async Task<bool> FuncThatOnlyReturnsNowFuncTaskGeneric(Func<Task<bool>> func)
        {
            return await func();
        }

        public async Task<bool> FuncThatReturnsAndNeedsParameterNowFuncTaskGeneric(Func<string, Task<bool>> task)
        {
            return await task(arg: "FuncThatReturnsAndNeedsParameterNowFuncTaskGeneric");
        }
    }
}
