﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyStaging.xUnitTest
{
    public class ConstantUtil
    {
        /// <summary>
        ///  数据库连接字符串
        /// </summary>
        public static string CONNECTIONSTRING = "Host=127.0.0.1;Port=5432;Username=postgres;Password=postgres;Database=mystaging;Pooling=true;Maximum Pool Size=50;Timeout=300;CommandTimeout=300;";
    }
}
