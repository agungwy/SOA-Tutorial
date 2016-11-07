using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBook" in both code and config file together.
    [DataContract]
    public class IBook
    {
        private string id;
        private string name;
        private string author;
        private int year;
        private float price;
        private int stock;

        [DataMember]
        public string ID
        {
            get { return id; }

            set  { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        [DataMember]
        public string Author
        {
            get { return author; }

            set { author = value; }
        }

        [DataMember]
        public int Year
        {
            get { return year; }

            set { year = value; }
        }

        [DataMember]
        public float Price
        {
            get { return price; }

            set { price = value; }
        }

        [DataMember]
        public int Stock
        {
            get { return stock; }

            set { stock = value; }
        }


    }
}
