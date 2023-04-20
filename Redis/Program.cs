using StackExchange.Redis;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Connection to redis server
            var options = new ConfigurationOptions
            {
                EndPoints = { { "127.0.0.1", 7000 } },
                ConnectTimeout = 10000,
                SyncTimeout = 10000,
                AbortOnConnectFail = false
            };

            ConnectionMultiplexer redisConnection = ConnectionMultiplexer.Connect(options);

            // 2. Get the reference of Rdb using the connection
            IDatabase redisDbConnection = redisConnection.GetDatabase(4);


            Console.WriteLine("Test");
            string key = "name", value = "Hemakshi";


            redisDbConnection.StringSet(key, value);

            var keyValue = redisDbConnection.StringGet("name");
            Console.WriteLine(keyValue);

            Console.WriteLine("Hash DataType Example:");
            HashEntry[] EmployeeObj = {new HashEntry("Employee Code", "GT5082"),new HashEntry("Designation", "Cloud Engineer"), new HashEntry("Team", "Engineering")};

            redisDbConnection.HashSet("EmployeeMasterKey", EmployeeObj);
            var allHash = redisDbConnection.HashGetAll("EmployeeMasterKey");
            foreach (var item in allHash)
            {
                Console.WriteLine(string.Format("key : {0}, value : {1}", item.Name, item.Value));
            }

            var userAgeSet = "users:age";
            var userLastAccessSet = "users:lastAccess";
            var userHighScoreSet = "users:highScores";
            var namesSet = "names";
            var mostRecentlyActive = "users:mostRecentlyActive";

            redisDbConnection.KeyDelete(new RedisKey[] { userAgeSet, userLastAccessSet, userHighScoreSet, namesSet, mostRecentlyActive });
            redisDbConnection.SortedSetAdd(userAgeSet,
        new SortedSetEntry[]
        {
            new("User:1", 20),
            new("User:2", 23),
            new("User:3", 18),
            new("User:4", 35),
            new("User:5", 55),
            new("User:6", 62)
        });

            redisDbConnection.SortedSetAdd(userLastAccessSet,
                new SortedSetEntry[]
                {
            new("User:1", 1648483867),
            new("User:2", 1658074397),
            new("User:3", 1659132660),
            new("User:4", 1652082765),
            new("User:5", 1658087415),
            new("User:6", 1656530099)
                });

            redisDbConnection.SortedSetAdd(userHighScoreSet,
                new SortedSetEntry[]
                {
            new("User:1", 10),
            new("User:2", 55),
            new("User:3", 36),
            new("User:4", 25),
            new("User:5", 21),
            new("User:6", 44)
                });

            redisDbConnection.SortedSetAdd(namesSet,
                new SortedSetEntry[]
                {
            new("John", 0),
            new("Fred", 0),
            new("Bob", 0),
            new("Susan", 0),
            new("Alice", 0),
            new("Tom", 0)
                });


            Console.Read();


        }
    }
}

