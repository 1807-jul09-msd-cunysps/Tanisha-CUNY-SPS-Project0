using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLibrary
{
        public enum State
        {
            AL, BR, CA, CN, CO, CU, EG, FR, HI, IL, MI, MO, NY, NM, NC, OH, PA, TN, TX, VA
        }
        public enum Country
        {
            US = 1, Brazil = 55, China = 86, Colombia = 57, Cuba = 53, Egypt = 20, France = 33
        }

        public class Person
        {
            public Person()
            {
                address = new Address();
                phone = new Phone();
            }
            public long Pid { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public Address address { get; set; }
            public Phone phone { get; set; }
            
            
        }
        public class Address
        {
            public long Pid { get; set; }
            public string houseNum { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public State State { get; set; }
            public Country Country { get; set; }
            public string zipCode { get; set; }
        }
        public class Phone
        {
            public long Pid { get; set; }
            public Country countrycode { get; set; }
            public string areaCode { get; set; }
            public string number { get; set; }
            public string ext { get; set; }




        }
    }








