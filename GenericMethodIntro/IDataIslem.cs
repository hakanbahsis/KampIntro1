using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethodIntro
{
    interface IDataIslem<T> where T:class,IData,new()
    {
        void Ekle(T veri);
        void Duzenle(T veri);
        void Sil(T veri);
        List<T> Listele();
    }
}
