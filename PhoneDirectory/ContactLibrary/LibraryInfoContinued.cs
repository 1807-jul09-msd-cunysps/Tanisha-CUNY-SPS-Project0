using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ContactLibrary
{
    public partial class LibraryInfo
    {
        public void Start() //Start
        {
            Console.SetWindowSize(140, 25);
            string input = "0";

            string startmessage = ("---Welcome to this phone directory---");
            string padding = "----------------------------------------------------";

            Console.WriteLine(startmessage.PadLeft((Console.WindowWidth + startmessage.Length) / 2));
            Console.WriteLine(padding.PadLeft((Console.WindowWidth + padding.Length) / 2));
            Console.WriteLine(padding.PadLeft((Console.WindowWidth + padding.Length) / 2));
            System.Threading.Thread.Sleep(1000);
            Read();
            Add();
            Delete();
            Search();
            Update();

            while (input != "end")
            {
                Console.WriteLine();
                startmessage = "---Select from one of the choices below---";
                Console.WriteLine(startmessage.PadLeft((Console.WindowWidth + startmessage.Length) / 2));
                startmessage = "R.Read     A.Add    D.Delete ";
                Console.WriteLine(startmessage.PadLeft((Console.WindowWidth + startmessage.Length) / 2));
                startmessage = "U.Update   S.Search    E.END  ";
                Console.WriteLine(startmessage.PadLeft((Console.WindowWidth + startmessage.Length) / 2));
                Console.Write("--");

                input = Console.ReadLine().ToString().ToLower();

                switch (input)
                {
                    case "1":
                    case "read":
                        this.Read();
                        break;

                    case "2":
                    case "add":
                        this.Add();
                        break;

                    case "3":
                    case "delete":
                        Console.WriteLine();
                        this.Delete();
                        break;

                    case "4":
                    case "update":
                        Console.WriteLine();
                        this.Update();
                        break;

                    case "5":
                    case "search":
                        Console.WriteLine();
                        this.Search();
                        break;

                    case "6":
                    case "end":

                        while (input != "end")
                        { }
                        Console.Clear();
                        Console.WriteLine();
                        startmessage = "--- Enjoy your day! ---";
                        Console.WriteLine(startmessage.PadLeft((Console.WindowWidth + startmessage.Length) / 2));
                        System.Threading.Thread.Sleep(1300);
                        break;
                }
                        foreach (var person in per)
                        {
                            Console.WriteLine($"\n{person.firstName},{person.lastName}||{person.phone.areaCode}-{person.phone.number},{person.address.houseNum}{person.address.Street},{person.address.State},{person.address.Country},{person.address.zipCode}");
                        }

                        string SeedPersons = Console.ReadLine();

                        string strQuery = "select * from Person";
                        string connectionString = "Data Source = rev - tanishacuny - server.database.windows.net; Initial Catalog = phoneApp; User ID = israel; Password = SbHb11914";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(
                                strQuery, connection);
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            try
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine(String.Format("{0}, {1}",
                                        reader[0], reader[1]));
                                }
                            }
                            finally
                            {
                                Console.Read();

                                reader.Close();
                            }
                        }
                }

            }
       }
}

