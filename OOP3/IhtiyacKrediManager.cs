﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BişeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //throw new NotImplementedException();
            Console.WriteLine("İhtıyaç kredisi ödeme planı hesaplandı ");
        }
    }
}
