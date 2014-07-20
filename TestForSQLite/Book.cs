using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForSQLite
{
    class Book
    {
        private int id;
        private string bookName;
        private decimal price;
        private string rowguid;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Rowguid
        {
            get { return rowguid; }
            set { rowguid = value; }
        }

        public Book()
        { }

        public Book(int _id, string _bookname, decimal _price, string _rowguid)
        {
            id = _id;
            bookName = _bookname;
            price = _price;
            rowguid = _rowguid;
        }  


    }
}
