using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Utils
{
    public class CheckLoginInterceptors : Grpc.Core.Interceptors.Interceptor
    {
        public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            Console.WriteLine("call");
            return base.UnaryServerHandler(request, context, continuation);
        }
    }
}
