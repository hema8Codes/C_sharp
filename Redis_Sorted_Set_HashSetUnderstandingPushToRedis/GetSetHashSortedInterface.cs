using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace RedisWorkClient
{
    public interface GetSetHashSortedInterface
    {
        void AddAndSaveHashSetData(string strkey, HashEntry[] Hedata);
        string GetHashSetData(string HashSetKey, string HashEntryKey);
        void SaveSortedSetData(string strkey, string strMem, double score);
        void ProcessAndGetSortedSetData(string key, long Score);

    }
}
