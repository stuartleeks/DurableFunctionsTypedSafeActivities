using Microsoft.Azure.WebJobs;
using System.Threading.Tasks;

namespace DurableFunctionHelpers // TODO - generate this dynamically
{
    public static class ActivityFunctionHelpers
	{
		public static Task<System.String> SayHello(this DurableOrchestrationContext context , System.String name) 
        {
            return context.CallActivityAsync<System.String>("Function1_Hello");
        }
		public static Task<System.String> SayHello2(this DurableOrchestrationContext context , System.String name, System.Int32 age) 
        {
            return context.CallActivityAsync<System.String>("Function2_Hello");
        }
	}
}
