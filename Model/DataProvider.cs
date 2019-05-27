using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataProvider
    {
        private static DataProvider ins;
        public static DataProvider Ins
        {
            get
            {
                if(ins == null)
                {
                    ins = new DataProvider();
                }
                return ins;
            }
            set
            {
                ins = value;
            }
        }

        public Model1 db { get; set; }

        private DataProvider()
        {
            db = new Model1();
        }
    }
}
