using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DTO;
using Newtonsoft.Json;

namespace Dal
{
    public class ParashaDal
    {
        public static List<Parashah> parashaList=getToraList();

        public ParashaDal()
        {
            //parashaList = getToraList();
        }

        public static void ConvertTxtToJason()
        {
            string jsonFilePath = @"S:\משותף כללי\הנדסאים שנה ב\תלמידות המדהימות\רחלי בן יקר\C#\פרויקט תנך\Tanach\Dal\tora.json";

            string[] lines = TextFuncs.readLines();
            List<Parashah> parashot = new List<Parashah>();
            Parashah currentParashah = null;
            Chapter currentChapter = null;
            int x = -1;
            foreach (var line in lines)
            {
                x++;
                // הסרת רווחים
                var trimmedLine = line.Trim();

                if (trimmedLine.StartsWith("^")) // פרשת
                {
                    if (currentParashah != null)
                    {
                        parashot.Add(currentParashah);
                    }
                    currentParashah = new Parashah { Title = trimmedLine.Substring(1).Trim() };
                }
                else if (trimmedLine.StartsWith("~")) // פרק
                {
                    if (currentChapter != null)
                    {
                        currentParashah.Chapters.Add(currentChapter);
                    }
                    currentChapter = new Chapter { Title = trimmedLine.Substring(1).Trim() };
                }
                else if (trimmedLine.StartsWith("!")) // פסוק
                {
                    if (currentChapter != null)
                    {
                        var pasookNumber = trimmedLine.Substring(3, trimmedLine.IndexOf('}') - 3).Trim();
                        //var pasookText = line.Substring(trimmedLine.Length).Trim();
                        var pasookText = lines[x + 1].Trim();
                        currentChapter.Psookim.Add(new Pasook { Number = pasookNumber, Text = pasookText });
                    }
                }
            }
            // הוספת הפרשה האחרונה
            if (currentChapter != null)
            {
                currentParashah.Chapters.Add(currentChapter);
            }
            if (currentParashah != null)
            {
                parashot.Add(currentParashah);
            }
            // המרת הרשימה ל-JSON
            string json = JsonConvert.SerializeObject(parashot, Newtonsoft.Json.Formatting.Indented);

            // שמירת ה-JSON לקובץ
            File.WriteAllText(jsonFilePath, json);
        }

        public static List<Parashah> getToraList()
        {
            string jsonFilePath = @"S:\משותף כללי\הנדסאים שנה ב\תלמידות המדהימות\רחלי בן יקר\C#\פרויקט תנך\Tanach\Dal\tora.json";
            string existingJson = File.ReadAllText(jsonFilePath);
            List<Parashah> lp = JsonConvert.DeserializeObject<List<Parashah>>(existingJson);
            return lp;
        }
    }
}
