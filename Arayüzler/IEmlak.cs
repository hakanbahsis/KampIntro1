using System;
using System.Collections.Generic;
using System.Text;

namespace Arayüzler
{
    interface IEmlak //interfacelerde erişim belirteçleri kullanılmaz.
    {//interfaceler tek başına bir anlam ifade etmiyor
        //interfaceler hiçbir şekilde newlenmezler.
         int MetreKare { get; set; }
         
         int Fiyat { get; set; }
        void Sat();//İnterface içinde yazı yazılmaz.
        void Kirala();
    }
}
