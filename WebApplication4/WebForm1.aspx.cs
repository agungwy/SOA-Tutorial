using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.ServiceReference2;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static Service1 service = new Service1();
        private static int counter = 1;
        private static Table table = new Table();
        private static List<TableRow> rows = new List<TableRow>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GetAllBooks(sender, e);
            Purchase.Click += new EventHandler(this.PurchaseBook);
            moreBook.Click += new EventHandler(this.MoreBook);
            addBook.Click += new EventHandler(this.AddBook);
            deleteBook.Click += new EventHandler(this.DeleteBook);
            searchBook.Click += new EventHandler(this.SearchBook);
            
            if (rows.Count == 0)
            {
                TableRow tr = new TableRow();

                TableCell tc = new TableCell();
                tc.Text = "Book Number";

                TableCell tc2 = new TableCell();
                TextBox tbNum = new TextBox();
                tbNum.ID = "numBook" + 0;
                tc2.Controls.Add(tbNum);

                TableCell tc3 = new TableCell();
                tc3.Text = "Amount";

                TableCell tc4 = new TableCell();
                TextBox tbNum2 = new TextBox();
                tbNum2.ID = "quantity" + 0;
                tc4.Controls.Add(tbNum2);

                tr.Cells.Add(tc);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);
                tr.Cells.Add(tc4);
                rows.Add(tr);
            }
            foreach (TableRow row in rows)
            {
                Table3.Rows.Add(row);
            }

        }

      



        protected void MoreBook(object sender, EventArgs e)
        {


            
            //for (var i = 1; i < counter; i++)
            //{
            TableRow tr = new TableRow();

            TableCell tc = new TableCell();
            tc.Text = "Book Number";

            TableCell tc2 = new TableCell();
            TextBox tbNum = new TextBox();
            tbNum.ID = "numBook" + counter;
            tc2.Controls.Add(tbNum);

            TableCell tc3 = new TableCell();
            tc3.Text = "Amount";

            TableCell tc4 = new TableCell();
            TextBox tbNum2 = new TextBox();
            tbNum2.ID = "quantity" + counter;
            tc4.Controls.Add(tbNum2);

            tr.Cells.Add(tc);
            tr.Cells.Add(tc2);
            tr.Cells.Add(tc3);
            tr.Cells.Add(tc4);
            rows.Add(tr);
            //}
        counter += 1;

            
           
                
            
            


        }
        protected void PurchaseBook(object sender, EventArgs e)
        {
            float f;
            bool var = true;
            if (!(float.TryParse(budget.Text, out f)))
            {
                outputPurchase.Text = "Wrong Input";
            }
            else
            {
                float Budget = float.Parse(budget.Text);
                Dictionary<int, int> buy = new Dictionary<int, int>();
                //buy.Add(Int32.Parse(TextBox1.Text), Int32.Parse(TextBox2.Text));
                Console.WriteLine("rows");
                Console.WriteLine(Table3.Rows.Count);
                Label11.Text = (Table3.Rows.Count).ToString();

                for (var i = 0; i < Table3.Rows.Count; i++)
                {
                    try
                    {
                        string numID = "numBook" + (i);
                        string qtyID = "quantity" + (i);
                        TableRow row = Table3.Rows[i];
                        Label10.Text = ((TextBox)row.Cells[1].FindControl(numID)).Text;
                        Label9.Text = ((TextBox)row.Cells[3].FindControl(qtyID)).Text;
                        string textCell = ((TextBox)row.Cells[1].FindControl(numID)).Text;
                        string textCell2 = ((TextBox)row.Cells[3].FindControl(qtyID)).Text;
                        int n;
                        if (textCell == "" || textCell2 == ""){
                            buy.Add(Int32.Parse(textCell), Int32.Parse(textCell2));
                        }
                        else if (!(Int32.TryParse(textCell, out n)) || !(Int32.TryParse(textCell2, out n)))
                        {
                            var = false;
                            break;
                        }
                        else
                        {
                            buy.Add(Int32.Parse(textCell), Int32.Parse(textCell2));
                        }



                        
                    }
                    catch
                    {

                    }


                }
                if (var == true)
                {
                    BookPurchaseResponse output = service.BookPurchaseInfo(Budget, buy);
                    outputPurchase.Text = output.response;
                }
                else
                {
                    outputPurchase.Text = "wrong input";
                }
                
            }
            

        }
        
        protected void SearchBook(object sender, EventArgs e)
        {
            if (option2.SelectedValue == "Name")
            {
                string name = inputSearch.Text;
                if (name != "")
                {
                    List<IBook> book = service.SearchBook("", name, "", 0);
                    this.MakeTable2(book);
                    value3.Text = "success";

                }
                else
                {
                    value3.Text = "value cannot be empty";
                }
            }
            else if (option2.SelectedValue == "ID")
            {
                string id = inputSearch.Text;
                if (id != "")
                {
                    List<IBook> book = service.SearchBook(id, "", "", 0);
                    this.MakeTable2(book);
                    value3.Text = "success";

                }
                else
                {
                    value3.Text = "value cannot be empty";
                }
            }
            else if (option2.SelectedValue == "Author")
            {
                string author = inputSearch.Text;
                if (author != "")
                {
                    List<IBook> book = service.SearchBook("", "", author, 0);
                    this.MakeTable2(book);
                    value3.Text = "success";

                }
                else
                {
                    value3.Text = "value cannot be empty";
                }
            }

            else
            {
                int n;
                if (!(Int32.TryParse(inputSearch.Text, out n)))
                {
                    value3.Text = "please input number";
                }
                else
                {
                    int year = Int32.Parse(inputSearch.Text);
                    if (year > 0)
                    {
                        List<IBook> book = service.SearchBook("", "", "", year);
                        this.MakeTable2(book);
                        value3.Text = "success";
                    }
                    else
                    {
                        value3.Text = "number cant be negative";
                    }
                }
                
            }
        }
        protected void DeleteBook(object sender, EventArgs e)
        {
            int n;
            
            if (option.SelectedValue == "Num")
            {
                if (!(Int32.TryParse(inputDelete.Text, out n)))
                {
                    value2.Text = "please input number";
                }
                else
                {
                    int num = Int32.Parse(inputDelete.Text);
                    if (num > 0)
                    {
                        if (service.DeleteBook(num, "", 0) == true)
                        {
                            value2.Text = "succes";
                            this.GetAllBooks(sender, e);
                        }
                        else
                        {
                            value2.Text = "book not found";
                        }

                    }
                    else
                    {
                        value2.Text = "number cant be negative";
                    }
                }
                
            }
            else if (option.SelectedValue == "ID")
            {
                string id = inputDelete.Text;
                if (id != "")
                {
                    if (service.DeleteBook(0, id, 0)== true)
                    {
                        value2.Text = "succes";
                        this.GetAllBooks(sender, e);
                    }
                    else
                    {
                        value.Text = "book not found";
                    }
                }
                else
                {
                    value2.Text = "value cannot be empty";
                }
            }
            else
            {
                if (!(Int32.TryParse(inputDelete.Text, out n)))
                {
                    value2.Text = "please input number";
                }
                else
                {
                    int year = Int32.Parse(inputDelete.Text);
                    if (year > 0)
                    {
                        if (service.DeleteBook(0, "", year) == true)
                        {
                            value2.Text = "succes";
                            this.GetAllBooks(sender, e);
                        }
                        else
                        {
                            value.Text = "book not found";
                        }
                    }
                    else
                    {
                        value2.Text = "number cant be negative";
                    }
                }
                
            }
        }
        protected void AddBook(object sender, EventArgs e)
        {
            int n;
            float f;
            if (inputName.Text.Equals("") || inputPrice.Text.Equals("") || inputID.Text.Equals("") || inputAuthor.Text.Equals("") || inputYear.Text.Equals("") || inputStock.Text.Equals(""))
            {
                value.Text = "There is empty box";
            }
            else if (!(Int32.TryParse(inputYear.Text, out n))|| !(Int32.TryParse(inputStock.Text, out n)) || !(float.TryParse(inputPrice.Text, out f)))
            {
                value.Text = "Please input number";
            }
            else
            {
                string id = inputID.Text;
                string name = inputName.Text;
                string author = inputAuthor.Text;
                int year = Int32.Parse(inputYear.Text);
                float price = float.Parse(inputPrice.Text);
                int stock = Int32.Parse(inputStock.Text);
                if (service.AddBook(id, name, author, year, price, stock) == true)
                {
                    this.GetAllBooks(sender, e);
                    value.Text = "success";
                }
                else
                {
                    value.Text = "Failed input the data";
                }

            }
        }
        protected void GetAllBooks(object sender, EventArgs e)
        {
            List<IBook> list = service.GetAllBooks();
            this.MakeTable(list);
        }
        protected void MakeTable2(List<IBook> books)
        {
            int x = 1;
            Table2.Rows.Clear();

            TableHeaderRow thr = new TableHeaderRow();

            TableHeaderCell thc1 = new TableHeaderCell();
            thc1.Text = "NUM";

            TableHeaderCell thc2 = new TableHeaderCell();
            thc2.Text = "ID";
            
            TableHeaderCell thc3 = new TableHeaderCell();
            thc3.Text = "NAME";

            TableHeaderCell thc4 = new TableHeaderCell();
            thc4.Text = "AUTHOR";

            TableHeaderCell thc5 = new TableHeaderCell();
            thc5.Text = "YEAR";

            TableHeaderCell thc6 = new TableHeaderCell();
            thc6.Text = "PRICE";

            TableHeaderCell thc7 = new TableHeaderCell();
            thc7.Text = "FLOAT";

            thr.Cells.Add(thc1);
            thr.Cells.Add(thc2);
            thr.Cells.Add(thc3);
            thr.Cells.Add(thc4);
            thr.Cells.Add(thc5);
            thr.Cells.Add(thc6);
            thr.Cells.Add(thc7);

            Table2.Rows.Add(thr);



            for (int i = 0; i < books.Count; i++)
            {
                IBook book = books[i];
                System.Diagnostics.Debug.Write(book);
                TableRow tr = new TableRow();

                TableCell tc1 = new TableCell();
                tc1.Text = Convert.ToString(x);
                x += 1;

                TableCell tc2 = new TableCell();
                tc2.Text = book.ID;

                TableCell tc3 = new TableCell();
                tc3.Text = book.Name;
                System.Diagnostics.Debug.Write(book.Name);

                TableCell tc4 = new TableCell();
                tc4.Text = book.Author;

                TableCell tc5 = new TableCell();
                tc5.Text = Convert.ToString(book.Year);

                TableCell tc6 = new TableCell();
                tc6.Text = Convert.ToString(book.Price);

                TableCell tc7 = new TableCell();
                tc7.Text = Convert.ToString(book.Stock);

                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);
                tr.Cells.Add(tc4);
                tr.Cells.Add(tc5);
                tr.Cells.Add(tc6);
                tr.Cells.Add(tc7);
                Table2.Rows.Add(tr);

            }
        }
        protected void MakeTable(List<IBook> books)
        {

            int x = 1;
            Table1.Rows.Clear();
            TableHeaderRow thr = new TableHeaderRow();

            TableHeaderCell thc1 = new TableHeaderCell();
            thc1.Text = "NUM";

            TableHeaderCell thc2 = new TableHeaderCell();
            thc2.Text = "ID";

            TableHeaderCell thc3 = new TableHeaderCell();
            thc3.Text = "NAME";

            TableHeaderCell thc4 = new TableHeaderCell();
            thc4.Text = "AUTHOR";

            TableHeaderCell thc5 = new TableHeaderCell();
            thc5.Text = "YEAR";

            TableHeaderCell thc6 = new TableHeaderCell();
            thc6.Text = "PRICE";

            TableHeaderCell thc7 = new TableHeaderCell();
            thc7.Text = "FLOAT";

            thr.Cells.Add(thc1);
            thr.Cells.Add(thc2);
            thr.Cells.Add(thc3);
            thr.Cells.Add(thc4);
            thr.Cells.Add(thc5);
            thr.Cells.Add(thc6);
            thr.Cells.Add(thc7);

            Table1.Rows.Add(thr);
            for (int i = 0; i < books.Count; i++)
            {
                IBook book = books[i];
                System.Diagnostics.Debug.Write(book);
                TableRow tr = new TableRow();

                TableCell tc1 = new TableCell();
                tc1.Text = Convert.ToString(x);
                x += 1;

                TableCell tc2 = new TableCell();
                tc2.Text = book.ID;

                TableCell tc3 = new TableCell();
                tc3.Text = book.Name;
                System.Diagnostics.Debug.Write(book.Name);

                TableCell tc4 = new TableCell();
                tc4.Text = book.Author;

                TableCell tc5 = new TableCell();
                tc5.Text = Convert.ToString(book.Year);

                TableCell tc6 = new TableCell();
                tc6.Text = Convert.ToString(book.Price);

                TableCell tc7 = new TableCell();
                tc7.Text = Convert.ToString(book.Stock);

                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);
                tr.Cells.Add(tc4);
                tr.Cells.Add(tc5);
                tr.Cells.Add(tc6);
                tr.Cells.Add(tc7);
                Table1.Rows.Add(tr);

            }
        }

        
    }
        
}