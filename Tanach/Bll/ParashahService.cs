using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ParashahService
    {
        public static void makeJsonFile() => ParashaDal.ConvertTxtToJason();
        public static List<Parashah> GetParashahs() => ParashaDal.getToraList();

        public static List<Place> FindWord(string word)//, //out int? counter)
        {
            string[] arr;
            List<Parashah> parashot = ParashaDal.parashaList;
            List<Place> places = new List<Place>();
            //counter = 0;
            foreach (var parashah in parashot)
            {
                foreach (var Chapter in parashah.Chapters)
                {
                    foreach (var pasook in Chapter.Psookim)
                    {
                        arr = pasook.Text.Split();
                        foreach (var s in arr)
                            if (s.Equals(word))
                            {
                                places.Add(new Place() { Parashah = parashah.Title, Perek = Chapter.Title, Pasook = pasook });
                                // counter++;
                            }
                    }
                }
            }
            return places;
            //var x = ParashahRepository.listP.Select(p => p.Chapters.Select(c=>c.Psookim.FirstOrDefault(p=>p.Text.Contains(word))).Select(d=>d.);//var x = ParashahRepository.listP.Select(p => p.Chapters.Select(c=>c.Psookim.FirstOrDefault(p=>p.Text.Contains(word))).Select(d=>d.);
        }

        public static List<string> getPsookim()
        {
            List<string> myTora = new List<string>();
            foreach (var parasha in ParashaDal.parashaList)
            {
                myTora.Add(parasha.Title + " ");
                foreach (var chapter in parasha.Chapters)
                {
                    myTora.Add(chapter.Title);
                    foreach (var pasook in chapter.Psookim)
                        myTora.Add($"{pasook.Number}" +": "+ $"{pasook.Text}");

                }
            }
            return myTora;
            //return ParashahRepository.listP.SelectMany(p => p.Chapters).SelectMany(c => c.Psookim).Select(p => $"{p.Number} {p.Text}").ToList();
        }
    }
}
