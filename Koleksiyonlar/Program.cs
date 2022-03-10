using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Hakan", "Baran", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine("-----Koleksiyonlar-----");
            ArrayListKoleksiyonu();
            HashTableKoleksiyonu();
            SortedListKoleksiyonu();
            StackKoleksiyonu();
            QueueKoleksiyonu();//Buraya kadar olan koleksiyonlar objelerle çalışıyor.Obje Referans Tiptir.
            ListKoleksiyonu();
            DictionaryKoleksiyonu();//Tip Bağımlı koleksiyonlardır.
            DigerKoleksiyonlar();


            Console.ReadKey();
        }

        private static void DigerKoleksiyonlar()
        {
            Console.WriteLine("-----SortedDictionary-----");
            SortedDictionary<string, string> sorted = new SortedDictionary<string, string>();
            //Dictionaryden tek farkı sıralama işlemi yapması
            Queue<string> stringQueue = new Queue<string>();//Sadece string türünde değer alır
            Stack<int> intStack = new Stack<int>();//sadece int türünde değer alır.
        }

        private static void DictionaryKoleksiyonu()
        {
            Console.WriteLine("-----Dictionary-----");
            //HashTableden farkı (HashTable Obje değerleri ile çalışıyor) istenilen değerle çalışma imkanı sunuyor.
            Dictionary<string, string> sozluk = new Dictionary<string, string>();//string tipinde değer alır.
            sozluk.Add("Desk", "Masa");
            sozluk.Add("Chair", "Sandalye");

            foreach (KeyValuePair<string, string> item in sozluk)//Hem Key hem de Value değerlerini yazdır
            {
                Console.WriteLine("ID = " + item .Key + "\t" + "Value = " + item.Value);
            }

            foreach (var item in sozluk.Values)//Doğrudan Value değerlerini yazdır
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine("Bir Kelime Girin");//istenilen Key değerinin Value değerini yazdır.
            Console.WriteLine(sozluk[Console.ReadLine()]);
        }

        private static void ListKoleksiyonu()
        {
            Console.WriteLine("----List----");
            List<string> isimler = new List<string>();
            isimler.Add("Hakan");//String türünde değer ekleme
            isimler.Add("Engin");//String türünde değer ekleme
            isimler.Add("Yazılım");//String türünde değer ekleme
            //isimler.Add(123);//Değer String olmadığından hata döndürür.
            isimler.AddRange(new string[] { "Baran", "Barış" });//Listeye birden fazla veri ekleme
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            isimler.Remove("Barış");//Listeden veri silme
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
        }

        private static void QueueKoleksiyonu()
        {
            Console.WriteLine("-----Queue-----");
            Queue queue = new Queue();//İlk giren ilk çıkar mantığı vardır.
            queue.Enqueue("Hakan");//Diziye eleman ekleme
            queue.Enqueue("Engin");
            queue.Enqueue("Yazılım");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Peek());//Çıkacak elemanı yazdır
            Console.WriteLine(queue.Dequeue());//Diziden eleman çıkarır
            Console.WriteLine(queue.Dequeue());//Diziden eleman çıkarır
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        private static void StackKoleksiyonu()
        {
            Console.WriteLine("-----Stack-----");
            Stack stack = new Stack();//En son giren eleman ilk çıkar mantığı vardır.
            stack.Push("Hakan");//Obje türünde eleman ekleme
            stack.Push(123);
            stack.Push(true);

            foreach (var item in stack)
            {
                Console.WriteLine(item);//ilk giren en son çıkar.
            }

            Console.WriteLine("----------");
            Console.WriteLine(stack.Peek());// Diziden ilk çıkacak elemana ulaşmak için kullanılır.
            Console.WriteLine("----------");
            Console.WriteLine(stack.Pop());//Diziye en son giren elemanı siler.
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedListKoleksiyonu()
        {
            Console.WriteLine("-----SortedList-----");
            SortedList sortedList = new SortedList();
            sortedList.Add(4, "Hakan");//Key değeri int tipinde olmalıdır.
            sortedList.Add(3, "Engin");
            sortedList.Add(5, "Yazılım");
            //HashTableden tek farkı değerleri sırayla yazdırması(Key değerine göre sıralar).

            foreach (var item in sortedList.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in sortedList.Values)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashTableKoleksiyonu()
        {
            Console.WriteLine("-----HashTable-----");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("A", "Hakan");// Key , Value
            hashtable.Add("B", 15);
            hashtable.Add("C", 73.5);
            hashtable.Add("D", 1);
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);//Key değerlerini ekrana yazıdr
            }

            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);//Value değerlerini ekrana yazdır.
            }
            Console.WriteLine("--------------------");
            //Değer Atama
            hashtable["B"] = "Lenovo";//Key değerinden value 15 olan değeri Lenovo olarak değiştir.
            //Değeri değiştirdiğimiz için tabloda en sona alınır.

            //Değere ulaşma
            Console.WriteLine(hashtable["B"]);
            //Değer silme
            hashtable.Remove("C");//Key değeri C olanı sil
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }
        }


        private static void ArrayListKoleksiyonu()
        {
            Console.WriteLine("-----Array List-----");
            ArrayList arrayList = new ArrayList(); //Obje türünden değer alır. 
            arrayList.Add(5);
            arrayList.Add(true);
            arrayList.Add("Hakan");
            arrayList.Add('H');
            arrayList.AddRange(new object[] { "Hakan", "Engin", 73.5, false });// Birden fazla obje türünden değer almak için kullanılır.

            foreach (var item in arrayList)//Foreach ile arrayList ekrana yazdır
            {
                Console.WriteLine(item);
            }
            //Doğrudan eleman ismiyle silme
            arrayList.Remove("Hakan");//Listede birden fazla  aynı değer varsa ilk bulduğunu siler.
            arrayList.RemoveAt(2);//indexe göre eleman silme. Hakan silindiği için ondan sonraki değer silinir.
            arrayList.RemoveRange(0, 3);//sıfırdan başla 3 kayıt sil.
            Console.WriteLine(arrayList[2]);//istenilen değere ulaşma
            arrayList[2] = false;//istenilen değeri değiştirme

            Console.WriteLine("---------");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arrayList.Capacity);//ArrayListten eleman silindiğinde kapasite değişmez.
        }
    }
}
