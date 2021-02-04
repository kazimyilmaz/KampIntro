﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService: ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }

    }


    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }

    }
}
