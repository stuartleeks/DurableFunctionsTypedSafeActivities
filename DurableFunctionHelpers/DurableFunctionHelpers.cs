using Microsoft.Azure.WebJobs;
using System.Threading.Tasks;

namespace DurableFunctionHelpers // TODO - generate this dynamically
{
    public static class ActivityFunctionHelpers
	{
		public static Task<string> SayHello(this DurableOrchestrationContext context) // TODO parameters and return type
        {
            return context.CallActivityAsync<string>("Function1_Hello");
        }
		public static Task<string> SayHello2(this DurableOrchestrationContext context) // TODO parameters and return type
        {
            return context.CallActivityAsync<string>("Function2_Hello");
        }
	}
}
