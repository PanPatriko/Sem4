using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ListEventArgs : EventArgs
    {
        // Private field exposed by the Text property
        private List<Person> filteredList;
        private List<String> filters;

        public ListEventArgs(List<Person> list, List<string> list2)
        {
            filteredList = list;
            filters = list2;
        }

        // Read only property.
        public List<Person> List
        {
            get { return filteredList; }
        }
        public List<String> List2
        {
            get { return filters; }
        }
    }
}
