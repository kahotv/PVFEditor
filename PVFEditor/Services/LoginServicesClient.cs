using Grpc.Net.Client;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PVFEditor.Services
{
    public class LoginServicesClient
    {
        static string m_tokenEndPoint = null;
        static HttpClient m_cli = null;

        private static void Init()
        {
            var url_is = "https://pvf.kaho.tv:5000/";
            var cli = new HttpClient();

            var disco = cli.GetDiscoveryDocumentAsync(url_is).Result;
            if (disco.IsError)
                throw new Exception(disco.Error);

            m_tokenEndPoint = disco.TokenEndpoint;
            m_cli = cli;
        }

        public static void Login(string name, string pwd)
        {
            Ready();
            if (m_cli != null)
            {
                var resp = m_cli.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = m_tokenEndPoint,
                    ClientId = "pc",
                    ClientSecret = "E6D936E6-4C5C-487B-A113-CFF92FA6C200",
                    UserName = name,
                    Password = pwd,
                    Scope = "pvf"
                }).Result;

                if (resp.IsError)
                    throw new Exception(resp.Error);

                m_cli.SetBearerToken(resp.AccessToken);
            }
        }

        private static void Ready()
        {
            if(m_cli == null)
            {
                Init();
            }
        }

        public static HttpClient GetHttpClient()
        {
            return m_cli;
        }

    }
}
