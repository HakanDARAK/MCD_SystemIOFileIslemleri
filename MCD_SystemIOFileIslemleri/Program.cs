using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIOFileIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileCreate("c:\\HakanDARAK\\Merhaba.txt");

            //FileDelete("c:\\HakanDARAK\\Merhaba.txt");

            //FileMove("c:\\HakanDARAK\\TXT3.txt", "c:\\HakanDARAK1\\TXT2.txt");

            //FileCopy("c:\\HakanDARAK\\TXT3.txt", "c:\\HakanDARAK1\\TXT3.txt");//HakanDARAK içinindeki TXT3 silinmeden HakanDARAK1 içine kopyalanıyor.

            //FileAppendAllText("c:\\HakanDARAK\\TXT3.text", "Eklenen değer");//Yeni TEXT dosyası ekliyor üstüne ekleme yapmıyor.

            //Console.WriteLine(FileReadAllText("c:\\HakanDARAK\\TXT3.txt"));
            //Console.ReadLine();
        }


        //Yeni Dosya Oluşturma
        static void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }


        //Var olan dosyayı silme
        static void FileDelete(string path)
        {
            File.Delete(path);
        }


        //Dosya konumunu yer degistirme
        static void FileMove(string kaynak, string hedef)
        {
            File.Move(kaynak, hedef);   
        }
          

        //Doyayı başka bir yere kopyalma
        static void FileCopy(string kaynak,string hedef)
        {
            File.Copy(kaynak, hedef);
        }


        //verilen adrese dosya ekleme yapma
        static void FileAppendAllText(string path , string deger)
        {
            File.AppendAllText(path, deger);
        }


        //Verilen adresteki dosyayı okuma
        static string FileReadAllText(string path)
        {
            string metinDegeri =File.ReadAllText(path);
            return metinDegeri;
        }
    }
}
