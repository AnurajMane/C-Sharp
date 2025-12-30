using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    internal class Book
    {
        private int _id;
        private string _title;
        private string _author;
        private int _year;



        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private static int generateId = 0;

        public Book(string title, string author, int year)
        {
            this._id = ++generateId;
            this._title = title;
            this._author = author;
            this._year = year;
        }


        public string toString()
        {
            return "Current book is --> ID : " + this._id + " Title : " + this._title + " Auther is : " + this._author + "]";
        }


    }
}