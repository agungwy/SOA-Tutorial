using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<IBook> GetAllBooks();

        [OperationContract]
        Boolean AddBook(string ID, string name, string author, int year, float price, int stock);
        [OperationContract]
        Boolean DeleteBook(int num, string id, int year);

        [OperationContract]
        List<IBook> SearchBook(string id, string name, string author, int year);

    }
    
 
}
