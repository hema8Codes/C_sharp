using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisWorkClient
{

    public class CacheConnection
    {
        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {


            var options = new ConfigurationOptions
            {
                EndPoints = { { "127.0.0.1", 7000 } },
                ConnectTimeout = 60000,
                SyncTimeout = 60000,
                AbortOnConnectFail = false
            };


            return ConnectionMultiplexer.Connect(options);


        }, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }


    }
}
