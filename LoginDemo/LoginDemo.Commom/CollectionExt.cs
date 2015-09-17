﻿using Newtonsoft.Json;

namespace LoginDemo.Commom
{
    public static class CollectionExtx
    {
        /// <summary>
        /// obj serialize to string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string SerializeObj2String<T>(this T t)
        {
            return JsonConvert.SerializeObject(t);
        }
    }
}