using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ajaxQuizOrnegi.Models;

namespace ajaxQuizOrnegi.BL
{
    public class MesajIslemleri
    {
        public static VeriKatmani db = new VeriKatmani();
        public static string MesajEkle(string mesaj)
        {
            try
            {
                db.MesajListesi.Add(mesaj);
                return "+";
            }catch(Exception ex)
            {
                return null;
            }
        }

        public static List<string> MesajlariListele()
        {
            try
            {
                return db.MesajListesi;
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}