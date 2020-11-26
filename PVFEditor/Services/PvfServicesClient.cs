using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PVFEditor.Services
{
    public class PvfServicesClient
    {
        static PVFServices.Pvf.PvfClient m_cli = null;

        public static void Init(HttpClient httpclient, Action<string> errcallback)
        {
            if (m_cli == null)
            {
                var channel = GrpcChannel.ForAddress("https://pvf.kaho.tv:5001/", new GrpcChannelOptions()
                {
                    HttpClient = httpclient
                });

                var invoker = channel.Intercept(new ExceptionInterceptor(errcallback));

                var client = new PVFServices.Pvf.PvfClient(invoker);
                client.TestConnect(new Google.Protobuf.WellKnownTypes.Empty());
                m_cli = client;
            }
        }

        public static PVFServices.Pvf.PvfClient GetInterface()
        {
            return m_cli;
        }
    }

    class ExceptionInterceptor : Interceptor
    {
        Action<string> m_cb = null;
        public ExceptionInterceptor(Action<string> cb_err)
        {
            m_cb = cb_err;
        }
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            try
            {
                return continuation(request, context);
            }
            catch (RpcException e)
            {
                if (m_cb != null)
                {
                    m_cb(e.Status.Detail);
                }
                else
                {
                    throw;
                }
            }

            return null;
        }
    }
}
