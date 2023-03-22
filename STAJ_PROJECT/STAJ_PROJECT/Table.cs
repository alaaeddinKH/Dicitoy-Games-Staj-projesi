using System;
using System.Collections.Generic;
using System.Text;

namespace STAJ_PROJECT
{
    public enum table_attribute
    {
        fast = 1 << 0,//     no 0
        one_to_one = 1 << 1,//  no 1
        revenge = 1 << 2, //  no 2
    }

    public class Table
    {
        private int no;//alternatif = also we can used unique number
        private int bet_amount;
        public table_attribute table_type;

        public int NO
        {
            get { return no; }
            private set { no = value; }
        }

        public int Bet_Amount
        {
            get { return bet_amount; }
            private set 
            { 
                if(value>=200 && value<=5000)
                {
                    bet_amount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public table_attribute Table_Type
        {
            get { return table_type; }
            private set { table_type = value; }
        }

        public Table(int no, int bet, table_attribute type)//constracter
        {
            this.NO = no;
            this.Bet_Amount = bet;
            this.table_type = type;
        }
        public override string ToString() // we used morphism to changed Tostring method
        {
            string S = "";
            if((this.Table_Type & table_attribute.fast) != 0)
            {
                S += "Hızlı\n";
            }
            if ((this.Table_Type & table_attribute.one_to_one) != 0)
            {
                S += "Teke tek\n";
            }
            if ((this.Table_Type & table_attribute.revenge) != 0)
            {
                S += "Rövanş\n";
            }
            return "Table No: " + this.NO.ToString() + "\n" +
                   S +  "\n" +
                   "Table Amount: " + this.Bet_Amount;
        }
    }
}
