using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCounters.bus
{
    public class Date 
    {
        private int month;
        private int day;
        private int year;

        public int Month 
        { 
            get { return this.month; }

            set { this.month = value; }
        }
        public int Day 
        {
            get { return this.day; }

            set { this.day = value; }
        }
        public int Year 
        {
            get { return this.year; }

            set { this.year = value; }
        }
        public Date() 
        {
            this.month = 1;
            this.day = 1;
            this.year = 1;
        }
        public Date(int month, int day, int year) 
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }
        public string GetDateState() 
        {
            string state;
            state = this.month + "/" + this.day + "/" + this.year;
            return state;
        }
    }
}
