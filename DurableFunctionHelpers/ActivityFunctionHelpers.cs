using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DurableFunctionHelpers
{
    public static class ActivityFunctionHelpers_ManuallyCreated
    {
        // Idea is that this file would be auto-generated
        // Look for functions with ActivityTrigger attribute
        // Would need to think about ignoring "TextWriter log" etc 
        // Also, should the function name here map to the FunctionName attribute value or the C# function name?
        public static Task<string> SayHello(this DurableOrchestrationContext context, string name)
        {
            return context.CallActivityAsync<string>("Function1_Hello", name);
        }
    }
}
