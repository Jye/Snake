using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game
    {

        public Game(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public int Rows
        {
            get;
            private set;
        }

        public int Columns
        {
            get;
            private set;
        }
    }
}
