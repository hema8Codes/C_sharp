using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace RedisWorkClient
{
    // This class HashSortedImplementation implements the interface GetSetHashSortedInterface
    public class HashSortedImplementation : GetSetHashSortedInterface
    {
        // Which database we are using -> is it 0, 1, 2 or 3 etc.
        int whichRedisDb = 0;

        // 1. This method -> Get the value of a hash field
        public string GetHashSetData(string HashSetKey, string HashEntryKey)
        {

            if (string.IsNullOrEmpty(HashSetKey) == true || string.IsNullOrEmpty(HashEntryKey) == true) // case -> check if string is null or empty
                return null;

            /*
              IDatabase can be thought of as the primary interactive interface to Redis. 
            It provides a single interface for your entire Redis Instance, and is the preferred 
            interface when you are executing single commands that manipulate your application's data to Redis.
             */

            StackExchange.Redis.IDatabase RedisDb;

            RedisDb = CacheConnection.Connection.GetDatabase(whichRedisDb);

            if (RedisDb.HashExists(HashSetKey, HashEntryKey)) // check if the value is in-memory
            {

                string getval = Convert.ToString(RedisDb.HashGet(HashSetKey, HashEntryKey)); // get value from in-memory
                return getval;
            }
            else
                return null;

        }



        

        /*
        // Our HashSet looks like this conceptually:
        //    myHashKey = {
        //       myFieldKey: "my value"
        //    }
        //
        */

        // 3. Set a hash value or Add a value to hashset
        public void AddAndSaveHashSetData(string strkey, HashEntry[] Hedata)
        {
            if (string.IsNullOrEmpty(strkey) == true)// case -> check if string is null or empty
                return;

            StackExchange.Redis.IDatabase RedisDb;

            RedisDb = CacheConnection.Connection.GetDatabase(whichRedisDb);

            // Set a hash key/value
            RedisDb.HashSetAsync(strkey, Hedata);

        }



        public void ProcessAndGetSortedSetData(string key, long value)
        {
            StackExchange.Redis.IDatabase RedisDb;
            RedisDb = CacheConnection.Connection.GetDatabase(whichRedisDb);

    

            if (RedisDb != null && RedisDb.KeyExists(key))
            {
                var pending = RedisDb.SortedSetRangeByScoreWithScoresAsync(key: key,
                                              start: (long)value,
                                              stop: double.PositiveInfinity,
                                              order: Order.Descending);



                var redisValueSorted = RedisDb.Wait(pending);
                foreach ( var val in redisValueSorted)
                {
                    Console.WriteLine($" the value : {val}");
                }
              

            }
            else
                return;
        }


        public void SaveSortedSetData(string strkey, string strMem, double score)
        {
            if (string.IsNullOrEmpty(strkey) == true)
                return;

            StackExchange.Redis.IDatabase redis;
            redis = CacheConnection.Connection.GetDatabase(whichRedisDb);

            redis.SortedSetAdd(key: strkey, member: strMem,score: score);
        }
    }
}
