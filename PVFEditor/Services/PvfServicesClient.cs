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
        static string addr = "https://pvf.kaho.tv:5002/";
        static PVFServices.Pvf.PvfClient m_cli = null;

        public static void Init(Action<string> errcallback, HttpClient httpclient = null)
        {
            if (m_cli == null)
            {
                GrpcChannel channel = null;

                if(httpclient != null)
                {
                    channel = GrpcChannel.ForAddress(addr, new GrpcChannelOptions()
                    {
                        HttpClient = httpclient,
                        MaxSendMessageSize = 30 * 1024 * 1024,
                        MaxReceiveMessageSize = 30 * 1024 * 1024
                    });
                }
                else
                {
                    channel = GrpcChannel.ForAddress(addr, new GrpcChannelOptions() 
                    {
                        MaxSendMessageSize = 30 * 1024 * 1024,
                        MaxReceiveMessageSize = 30 * 1024 * 1024
                    });
                }

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
