using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       
        // change "books.txt" the path to the location of books.txt


        public BookPurchaseResponse BookPurchaseInfo(float budget, Dictionary<int, int> items)
        {
            List<IBook> books = this.GetAllBooks();
            float price = 0;

            BookPurchaseResponse response = new BookPurchaseResponse();
            foreach (int key in items.Keys)
            {
                if (key > (books.Count))
                {
                    response.result = false;
                    response.response = "The book does not exist";
                    return response;
                }
                else if (books[key-1].Stock < items[key])
                {
                    response.result = false;
                    response.response = "No enough stocks";
                    return response;
                    
                }
                
                price = price + (books[key - 1].Price * items[key]);



            }

            if (price > budget)
            {
                response.result = false;
                response.response = "No enough money";
                return response;
                
            }
            float result = budget - price;

            response.result = true;
            response.response = Convert.ToString(result);
            return response;
            

        }



        public List<IBook> SearchBook(string id, string name, string author, int year)
        {
            List<IBook> books = this.GetAllBooks();
            List<IBook> tempBooks = new List<IBook>();
            for (var i = 0; i < books.Count; i++)
            {
                if (name == "")
                {
                    if (author == "")
                    {
                        if ((books[i].ID == id || books[i].Year == year ))
                        {
                            tempBooks.Add(books[i]);


                        }
                    }
                    else
                    {
                        if ((books[i].ID == id || books[i].Year == year || books[i].Author.ToLower().Contains(author.ToLower())))
                        {
                            tempBooks.Add(books[i]);


                        }
                    }

                }
                else if (author == "")
                {
                    if (name == "")
                    {
                        if ((books[i].ID == id || books[i].Year == year))
                        {
                            tempBooks.Add(books[i]);


                        }
                    }
                    else
                    {
                        if ((books[i].ID == id || books[i].Year == year || books[i].Name.ToLower().Contains(name.ToLower())))
                        {
                            tempBooks.Add(books[i]);


                        }
                    }
                }

            }
            return tempBooks;

        }
        public Boolean DeleteBook(int num, string id, int year)
        {
            List<IBook> books = this.GetAllBooks();
            Boolean value = false;
            List<IBook> tempBooks= new List<IBook>();
            for (var i = 0; i < books.Count; i++)
            {
                if (num != i+1 && books[i].ID != id && books[i].Year != year)
                {
                    tempBooks.Add(books[i]);
                   
                   
                }
                else
                {
                    value = true;
                }
               
            }
            books = tempBooks;

            if (value == true)
            {
                var tempFile = System.IO.Path.GetTempFileName();
                for (var i = 0; i < books.Count; i++)
                {
                    string syear = Convert.ToString(books[i].Year);
                    string sprice = Convert.ToString(books[i].Price);
                    string sstock = Convert.ToString(books[i].Stock);

                    string newLine = books[i].ID + "," + books[i].Name + "," + books[i].Author + "," + syear + "," + "$" + sprice + "," + sstock ;
                    System.IO.File.AppendAllText(tempFile, Environment.NewLine +newLine);
                }
                // change "books.txt" the path to the location of books.txt
                System.IO.File.Delete("books.txt");
                System.IO.File.Move(tempFile, "books.txt");
                return true;
            }
            else
            {
                return false;
            }
            
            



        }
        public Boolean AddBook(string ID, string name, string author, int year, float price, int stock)
        {
            List<IBook> books = this.GetAllBooks();
            if (year < 0 || price < 0 || stock <0 || ID == "" || name == "" || author == "")
            {
                return false;
            }
            
            
            else
            {
                for (var i = 0; i < books.Count; i++)
                {
                    if (books[i].ID == ID)
                    {
                        return false;
                    }
                }

                IBook book = new IBook();
                book.ID = ID;
                book.Name = name;
                book.Author = author;
                book.Year = year;
                book.Price = price;
                book.Stock = stock;
                books.Add(book);
                
                string syear = Convert.ToString(year);
                string sprice = Convert.ToString(price);
                string sstock = Convert.ToString(stock);

                string newLine = ID + "," + name + "," + author + "," + syear + "," + "$" + sprice + "," + sstock;
                // change "books.txt" the path to the location of books.txt
                System.IO.File.AppendAllText("books.txt", Environment.NewLine + newLine );
                return true; 
            }
            
        }

        public List<IBook> GetAllBooks()
        {
            List<IBook> books = new List<IBook>();
            string lines;
            
            // change "books.txt" the path to the location of books.txt
            System.IO.StreamReader file = new System.IO.StreamReader("books.txt");
            while ((lines = file.ReadLine()) != null)
            {
                try
                {
                    System.Diagnostics.Debug.Write(lines);
                    string[] separators = { ",", "$" };
                    string[] line = lines.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    IBook book = new IBook();
                    book.ID = line[0];
                    book.Name = line[1];
                    book.Author = line[2];
                    book.Year = Int32.Parse(line[3]);

                    book.Price = float.Parse(line[4]);
                    book.Stock = Int32.Parse(line[5]);
                    books.Add(book);
                    System.Diagnostics.Debug.Write(line);
                }
                catch
                {

                }

                


            }
            

            file.Close();
            
            return books;
        }

        
        
    }
}
