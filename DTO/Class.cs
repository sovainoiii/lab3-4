using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class
    {
        private string _CLASS_ID;
        private string _CLASS_NAME;
        private int _CLASS_YEAR;
        public string CLASS_ID
        {
            set { this._CLASS_ID = value; }
            get { return this._CLASS_ID; }
        }
        public string CLASS_NAME
        {
            set { this._CLASS_NAME = value; }
            get { return this._CLASS_NAME; }
        }
        public int CLASS_YEAR
        {
            set { this._CLASS_YEAR = value; }
            get { return this._CLASS_YEAR; }
        }
        public Class()
        {
        }
        public Class(string classID, string className, int year)
        {
            CLASS_ID = classID;
            CLASS_NAME = className;
            CLASS_YEAR = year;
        }
    }
}
