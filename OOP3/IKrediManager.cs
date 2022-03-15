using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interfaceler kurallar içerir. interface implemenete eden classlar bu kuralları kendine göre doldurur.
        //interfaceler genellikle operasyonel metotlarda kullanılır.
        //interfaceleri birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlar için kullanırız.
         void Hesapla();
        void BiseyYap();   
    }
}
