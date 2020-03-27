﻿using System.Reflection;
using System.Threading.Tasks;

namespace Xpand.Extensions.Reflection{
    public partial class ReflectionExtensions{
        public static async Task<object> InvokeAsync(this MethodInfo @this, object obj, params object[] parameters){
            dynamic awaitable = @this.Invoke(obj, parameters);
            await awaitable;
            return awaitable.GetAwaiter().GetResult();
        }
    }
}