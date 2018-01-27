using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{
    public class Quest : ISearchableObject
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string GetSearchValue()
        {
            return name;
        }
    }
}
