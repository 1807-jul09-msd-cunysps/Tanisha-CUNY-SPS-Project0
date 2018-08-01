using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactLibrary;


namespace ContactLibrary
{
    public partial class LibraryInfo
    {
        public List<Person> per = new List<Person>();

        public void Read() //Read
        {
            Console.WriteLine("---Show all Contacts in Directory---");
            foreach (Person person in per)
            {
                Console.WriteLine($"\n{person.firstName},{person.lastName}||{person.phone.areaCode}-{person.phone.number},{person.address.houseNum}-{person.address.Street},{person.address.State},{person.address.Country},{person.address.zipCode}\n");
            }
        }

        public void SeedPersons()
        {
            Person per1 = new Person();
            per1.firstName = "Richard";
            per1.lastName = "Greene";
            per1.Pid = DateTime.Now.Ticks;
            per1.address.houseNum = "1325";
            per1.address.Pid = per1.Pid;
            per1.address.Street = "Clean Street";
            per1.address.City = "New York";
            per1.address.State = State.NY;
            per1.address.Country = Country.US;
            per1.address.zipCode = "10035";
            per1.phone.Pid = per1.Pid;
            per1.phone.areaCode = "212";
            per1.phone.countrycode = Country.US;
            per1.phone.ext = "";
            per1.phone.number = "135-7890";


            Person per2 = new Person();
            per2.firstName = "Rosa";
            per2.lastName = "Baker";
            per2.Pid = DateTime.Now.Ticks;
            per2.address.houseNum = "1426";
            per2.address.Pid = per2.Pid;
            per2.address.Street = "Dirt Ave.";
            per2.address.City = "Altavista";
            per2.address.State = State.VA;
            per2.address.Country = Country.US;
            per2.address.zipCode = "24517";
            per2.phone.Pid = per2.Pid;
            per2.phone.areaCode = "703";
            per2.phone.countrycode = Country.US;
            per2.phone.ext = "";
            per2.phone.number = "622-5678";

            Person per3 = new Person();
            per3.firstName = "Stephine";
            per3.lastName = "Gonzalez";
            per3.Pid = DateTime.Now.Ticks;
            per3.address.houseNum = "7865";
            per3.address.Pid = per3.Pid;
            per3.address.Street = "Stacy Ave.";
            per3.address.City = "Beverly Hills";
            per3.address.State = State.CA;
            per3.address.Country = Country.US;
            per3.address.zipCode = "90209";
            per3.phone.Pid = per3.Pid;
            per3.phone.areaCode = "209";
            per3.phone.countrycode = Country.US;
            per3.phone.ext = "";
            per3.phone.number = "456-6228";

            Person per4 = new Person();
            per4.firstName = "Tyler";
            per4.lastName = "Woods";
            per4.Pid = DateTime.Now.Ticks;
            per4.address.houseNum = "4532";
            per4.address.Pid = per4.Pid;
            per4.address.Street = "Christopher Street";
            per4.address.City = "Huntsville";
            per4.address.State = State.AL;
            per4.address.Country = Country.US;
            per4.address.zipCode = "35816";
            per4.phone.Pid = per4.Pid;
            per4.phone.areaCode = "205";
            per4.phone.countrycode = Country.US;
            per4.phone.ext = "";
            per4.phone.number = "765-9723";

            Person per5 = new Person();
            per5.firstName = "Trevor";
            per5.lastName = "Brown";
            per5.Pid = DateTime.Now.Ticks;
            per5.address.houseNum = "2145";
            per5.address.Pid = per5.Pid;
            per5.address.Street = "Dream Road";
            per5.address.City = "Sprinfield";
            per5.address.State = State.IL;
            per5.address.Country = Country.US;
            per5.address.zipCode = "62701";
            per5.phone.Pid = per5.Pid;
            per5.phone.areaCode = "309";
            per5.phone.countrycode = Country.US;
            per5.phone.ext = "";
            per5.phone.number = "345-2867";

            Person per6 = new Person();
            per6.firstName = "Haillie";
            per6.lastName = "Stevens";
            per6.Pid = DateTime.Now.Ticks;
            per6.address.houseNum = "2347";
            per6.address.Pid = per6.Pid;
            per6.address.Street = "Parker Ave.";
            per6.address.City = "Cold Water";
            per6.address.State = State.MI;
            per6.address.Country = Country.US;
            per6.address.zipCode = "49036";
            per6.phone.Pid = per6.Pid;
            per6.phone.areaCode = "231";
            per6.phone.countrycode = Country.US;
            per6.phone.ext = "";
            per6.phone.number = "167-5439";

            per.Add(per1);
            per.Add(per2);
            per.Add(per3);
            per.Add(per4);
            per.Add(per5);
            per.Add(per6);


        }

        public void Add() //Add
        {

            Person per1 = new Person();

            per1.Pid = 201;
            per1.address.Pid = per1.Pid;
            per1.phone.Pid = per1.Pid;

            Console.WriteLine("Enter a First Name:");
            Console.Write("--");
            per1.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            Console.Write("--");
            per1.lastName = Console.ReadLine();

            Console.WriteLine("Enter house number:");
            Console.Write("--");
            per1.address.houseNum = Console.ReadLine();

            Console.WriteLine("Street:");
            Console.Write("--");
            per1.address.Street = Console.ReadLine();

            Console.WriteLine("City:");
            Console.Write("--");
            per1.address.City = Console.ReadLine();

            Console.Write("Enter One of the following states: AL, CA, CO, IL, MI, MO, NY, NC, OH, PA, VA:");
            string input = Console.ReadLine().ToString().ToLower();
            switch (input)
            {
                case "NY":
                    per1.address.State = State.NY;
                    break;

                case "AL":
                    per1.address.State = State.AL;
                    break;

                case "CA":
                    per1.address.State = State.CA;
                    break;

                case "CO":
                    per1.address.State = State.CO;
                    break;

                case "IL":
                    per1.address.State = State.IL;
                    break;

                case "MI":
                    per1.address.State = State.MI;
                    break;

                case "NC":
                    per1.address.State = State.NC;
                    break;

                case "PA":
                    per1.address.State = State.PA;
                    break;

                case "VA":
                    per1.address.State = State.VA;
                    break;

                case "MO":
                    per1.address.State = State.MO;
                    break;
                default:
                    break;
            }

            Console.Write("Enter One of the following Countries:  BR, CN, CO, CU,EG, FR, US,");
            input = Console.ReadLine().ToString().ToLower();
            switch (input)
            {
                case "US":
                    per1.address.Country = Country.US;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Zip Code:");
            Console.Write("--");
            per1.address.zipCode = Console.ReadLine();

            Console.WriteLine("Area Code:");
            Console.Write("--");
            per1.phone.areaCode = Console.ReadLine();

            Console.WriteLine("Phone number:");
            Console.Write("--");
            per1.phone.number = Console.ReadLine();



            per.Add(per1);



        }

        public void Delete() //Delete
        {
            string firstName;
            Console.WriteLine("Enter the first Name of the person you want to delete:");
            Console.Write("--");
            firstName = Console.ReadLine();

            var item = per.SingleOrDefault(p => p.firstName.ToString() == firstName);
            if (item != null)
            {
                per.Remove(item);
                Console.WriteLine("---The person has been deleted---");
            }

            else
                Console.WriteLine($"---This person does not exist:---");

        }



        public void Search() //Search
        {
            string category;
            string messageA = "--- Enter the contact you want to search for:---";
            string search;

            Console.WriteLine();
            Console.WriteLine("---Select from category:---");
            Console.WriteLine("  firstName \n" +
                              "  laststName \n" +
                              "  Phone \n");
            Console.Write("--");
            category = Console.ReadLine();

            switch (category.ToLower())
            {
                case "1":
                case "firstName":
                    Console.WriteLine(messageA);
                    Console.Write("--");
                    search = Console.ReadLine();

                    try
                    {
                        var result = per.Where(per => per.firstName.ToLower().Contains(search.ToLower()));
                        foreach (Person person in result)
                        {
                            Console.WriteLine($"\n{person.firstName},{person.lastName}||{person.phone.areaCode}-{person.phone.number},{person.address.houseNum}\n{person.address.Street},{person.address.State},{person.address.Country},{person.address.zipCode}");
                        }
                    }
                    catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); }
                    break;

                case "2":
                case "lastName":
                    Console.WriteLine(messageA);
                    Console.Write("--");
                    search = Console.ReadLine();

                    try
                    {
                        var result = per.Where(per => per.firstName.ToLower().Contains(search.ToLower()));
                        foreach (Person person in result)
                        {
                            Console.WriteLine($"\n{person.firstName},{person.lastName}||{person.phone.areaCode}-{person.phone.number},{person.address.houseNum}\n{person.address.Street},{person.address.State},{person.address.Country},{person.address.zipCode}");
                        }
                    }
                    catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); }
                    break;

                case "3":
                case "Phone":
                    Console.WriteLine(messageA);
                    Console.Write("--");
                    search = Console.ReadLine();

                    try
                    {
                        var result = per.Where(per => per.firstName.ToLower().Contains(search.ToLower()));
                        foreach (Person person in result)
                        {
                            Console.WriteLine($"\n{person.firstName},{person.lastName}||{person.phone.areaCode}-{person.phone.number},{person.address.houseNum}\n{person.address.Street},{person.address.State},{person.address.Country},{person.address.zipCode}");
                        }
                    }
                    catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); }
                    break;
                default:
                    Console.WriteLine("---You did not choose one of the choices---");
                    break;
            }
        }

        public void Update() //Update
        {
            long id = 0;
            Person per1 = new Person();

            Console.WriteLine("Enter the contact you want to update");
            Console.Write("--");

            try
            {
                id = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex) { Console.WriteLine("\n     " + ex.Message); return; }
            var query = from per in per
                        where per.Pid == id
                        select per1;

            if (query.Count() < 1)
            {
                Console.WriteLine();
                Console.WriteLine("---The Contact was not found, please try again later ---");
                Console.WriteLine();
                return;
            }
            foreach (Person x in query)
            {
                per1 = x;
            }
            string also = "yes";
            while (also == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("--- Enter the contact you want to update: ---");
                Console.WriteLine("         1.fistName     2.lastName    3.Address ");
                Console.Write("::");

                string input = Console.ReadLine().ToString().ToLower();
                switch (input)
                {
                    default:
                        Console.WriteLine("*******You did not enter one of the choices so goodbye XD*******");
                        break;

                }
            }
        }
    }
}
   


        
    
    
  


   

