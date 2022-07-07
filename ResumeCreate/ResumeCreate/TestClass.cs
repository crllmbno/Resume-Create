using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCreate
{
    internal class TestClass
    {
        public bool success { get; set; }
        public string message { get; set; }
        public IList<TestUsers> data;
    }
    internal class TestUsers
    {
        public string mandt { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string summary { get; set; }
        public string experiences { get; set; }
        public string skills { get; set; }
        public string education { get; set; }
    }
}
