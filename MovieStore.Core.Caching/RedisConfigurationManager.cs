﻿using System.Configuration;

namespace MovieStore.Core.Caching
{
    public class RedisConfigurationManager
    {
        #region Constants

        private const string SectionName = "RedisConfiguration";

        public static RedisConfigurationSection Config
        {
            get
            {
                RedisConfigurationSection redisConfigurationSection = (RedisConfigurationSection)ConfigurationManager.GetSection(SectionName);

                return redisConfigurationSection;
            }
        }

        #endregion
    }
}
