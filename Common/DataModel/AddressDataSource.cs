using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataModel
{
    public class AddressDataSource
    {
        public string Zipcode { get; private set; }
        public string Address { get; private set; }
        public string Name { get; private set; }


        public AddressDataSource(String zipcode, String address, String name)
        {
            this.Zipcode = zipcode;
            this.Address = address;
            this.Name = name;
        }

    }
}