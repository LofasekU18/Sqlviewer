using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLview.Model
{
    public class Sqles(string Name, string Sql)
    {
        public string Name { get; set; } = Name;
        public string Sql { get; set; } = Sql;
    }
}
