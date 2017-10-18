﻿using ArchitectureTemplate.Infrastructure.WCF.Proxies;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ArchitectureTemplate.Infrastructure.WCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWithTcp();
            GetWithHttp();
        }

        private static void GetWithTcp()
        {
            ScreenClient proxy = new ScreenClient("tcpEp");
            var data = proxy.GetByName("User");

            proxy.Close();
        }

        private static void GetWithHttp()
        {
            EndpointAddress address = new EndpointAddress("net.tcp://localhost:8009/WcfService");
            Binding binding = new NetTcpBinding();

            ScreenClient proxy = new ScreenClient(binding, address);
            var data = proxy.GetScreens("T");
            var teste = data.ToList();

            proxy.Close();
        }

    }
}