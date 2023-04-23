using System;
using System.Collections.Generic;

namespace structures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Kitaplar kitap1=new Kitaplar("YALIN CFO","Nicholas Katko",2019,166,"ORC PRess",kategoriler.Egitim);
            //kitap1.KitapBilgileri

        }
    }

    public enum kategoriler{
        Macera,Romantik,Fantastik,Polisiye,Egitim,Bilim
    }
    class Kitaplar{

        public string kitapAdi;
        public string yazarAdi;
        public int baskıYil;
        public int sayfaSayısı;
        public string yayinEvi;
        public kategoriler kategori;

        public Kitaplar(string bookname,string writer,int year,int pages,string publisher,kategoriler category){
            this.kitapAdi=bookname;
            this.yazarAdi=writer;
            this.baskıYil=year;
            this.sayfaSayısı=pages;
            this.yayinEvi=publisher;
            this.kategori=category;
            KitapBilgileri(bookname,writer,publisher,category);
        }

         public Kitaplar(string bookname,string writer,int year){ //override versiyon
            this.kitapAdi=bookname;
            this.yazarAdi=writer;
            this.baskıYil=year;
            
        }

        public void KitapBilgileri(string bookname,string writer,string publisher,kategoriler category){
            Console.WriteLine("Kitap adi={0}",bookname);
            Console.WriteLine("Yazar adi={0}",writer);
            Console.WriteLine("Yayın evi={0}",publisher);
            Console.WriteLine("Kategori={0}",category);
        }

    }
}