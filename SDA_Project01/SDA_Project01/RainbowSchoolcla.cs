using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace SDA_Project01
{
    class RainbowSchoolcla
    {
        readonly String Tfile = (@"C:\Users\HOME PC\Desktop\c#\RSchool.txt");
        public void AddT(int TI, string TN, string TC, string TS)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Tfile);
                string wTeacher = TI + "-" + TN + "-" + TC + "-" + TS + "\n";
                sw.Write(wTeacher);
                Console.WriteLine("The Entered Data Added" + "\n");
                sw.Close();
            }
            catch (Exception e)

            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
        public RainbowSchool GetT(int TI)
        {
            string[] l = File.ReadAllLines(Tfile);
            foreach (string s in l)
            {
                string[] line = s.Split("-");
                if (int.Parse(line[0]) == TI)
                {
                    RainbowSchool NewT = new RainbowSchool(int.Parse(line[0]), line[1], line[2], line[3]);
                    return NewT;
                }

            }

            return null;
        }
        public void TUpdate(int OTI,int TI, string TN, string TC, string TS)
        {
                var date1 = new DateTime();
                string[] lines = File.ReadAllLines(Tfile);
                bool status = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split("-");
                    if (int.Parse(line[0]) == OTI)
                    {
                        lines[i] = TI + "-" + TN + "-" + TC + "-" +TS;
                        status = true;
                    }
                }
                if (status)
                {
                    File.WriteAllLines(Tfile, lines);
                    Console.WriteLine("The data sucessfuly updated" + "\n" +"Last Update was on : "+ date1.ToString());
                }
        }

       




    }
}



