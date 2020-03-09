using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTask_2
{
    class ModifiedTextLines
    {
        private Dictionary <int, string> textLines = new Dictionary<int, string>();
        private int _numberLine = 1;

        public int NumberLine
        {
            get
            {
                return _numberLine;
            }
        }

        public void Add(string str)
        {
            textLines.Add(_numberLine, str);
            _numberLine++;            
        }

        public string Output(int number)
        {
            return textLines[number];
        }
    }
}
