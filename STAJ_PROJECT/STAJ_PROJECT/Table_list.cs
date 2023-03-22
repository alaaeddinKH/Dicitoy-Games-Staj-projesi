using System;
using System.Collections.Generic;
using System.Text;

namespace STAJ_PROJECT
{
    class Table_list
    {
        private List<Table> tables;
        private Table_list()
        {
            tables = new List<Table>();
        }
        public void AddTable(Table table)
        {
            tables.Add(table);
        }

       /* public Table FindTable(Table table)
        {
            
            foreach (Table item in tables)
            {
                if(table==item)
                {
                    

                }
            }
            return 1;
        }*/
    }
}
