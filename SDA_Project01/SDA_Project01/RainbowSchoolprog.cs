using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace SDA_Project01
{
    public class RainbowSchoolprog
    {
        public static void Main(string[] args)
        {
            RainbowSchoolcla school = new RainbowSchoolcla();
            Console.WriteLine("--------Rainbow School System-------");
            Console.WriteLine("Choose from the following:" + "\n" + "1/Add Data "+"\n"+ "2/Update the Data"+"\n"+ "3/View Data"+"\n"+ "4/exit");
            int? Tcho = null;
            int Tchose = int.Parse(Console.ReadLine());
            Tcho = Tchose;            
           // while(Tcho!=null)
            //{
                switch(Tcho)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("ID:");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Teacher's Name :");
                            string name = Console.ReadLine();
                            Console.WriteLine("Teacher's Class:");
                            string _class = Console.ReadLine();
                            Console.WriteLine("Tacher's Section:");
                            string section = Console.ReadLine();
                            school.AddT(id, name, _class, section);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please Enter The ID Number");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Please Enter the ID you looking for:");
                            int search_id = int.Parse(Console.ReadLine());
                            RainbowSchool RC = school.GetT(search_id);
                            if (RC != null)
                            {
                                Console.WriteLine($"The ID: {RC.ID}\nThe Name: {RC.TName}\nThe Class: {RC.Tclass}\nThe Section: {RC.TSection}");
                            }
                            else
                            {
                                Console.WriteLine("The ID you entered not exist !! ");
                            }
                            break;
                        }
                    case 3:
                        Console.WriteLine("Please Enter the ID for you want to update:");
                        int id_search = int.Parse(Console.ReadLine());
                        RainbowSchool RRC = school.GetT(id_search);
                        if (RRC != null)
                        {
                            Console.WriteLine($"The ID: {RRC.ID}\nTheName: {RRC.TName}\nThe Class: {RRC.Tclass}\nThe Section: {RRC.TSection}");
                            int old_id = RRC.ID;
                            Console.WriteLine("New ID:");
                            int new_id = int.Parse(Console.ReadLine());
                            Console.WriteLine(" New Name ");
                            string new_name = Console.ReadLine();
                            Console.WriteLine("New Class");
                            string new_class = Console.ReadLine();
                            Console.WriteLine("New Section");
                            string new_section = Console.ReadLine();
                            school.TUpdate(old_id, new_id, new_name, new_class, new_section);
                        }
                        else
                        {
                            Console.WriteLine("Can't Found This ID!!........-_- " + id_search);
                        }
                        break;
                    case 4:
                    Tcho = null;
                        break;
                    default:
                        Console.WriteLine("Plase chose 1 to 4 ");
                        break;
                }
            //}         
        }
       // public static void Main(string[] args)
       // {
         //   _ = new RainbowSchoolprog();
         //   Console.ReadKey();
    } 
}