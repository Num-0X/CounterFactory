using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCounters.bus
{
    public class Counter
    {
        private int number;
        private int value;
        private EnumColor color;
        private Date madeDate ;

        public int Number 
        { 
            get { return number; }

            set {this. number = value; }
        }
        public int Value
        {
            get { return value; }

            set { this.value = value; }
        }
        public EnumColor Color 
        {
            get { return color; }

            set { this.color = value; }
        }
        public Date MadeDate
        {
            get { return this.madeDate; }

            set { this.madeDate = value; }

        }
        public Counter(int number , int value , EnumColor color , Date madedate) 
        { 
            this.number = number ;
            this.value = value;
            this.color = color ;
            this.madeDate = madedate;
        }
        public Counter() 
        {
            this.number = 0 ;
            this.value = 0 ;
            this.color = EnumColor.UNDIFIEND;
            this.madeDate = new Date();
        }
        public string GetCounterState()
        {
            string state;

            state = this.number + "/" + this.value + "/" + this.color + "/" + this.madeDate;

            return state;

        }
    }
}
    

