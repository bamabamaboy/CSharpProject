using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTask {
    class User {

        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }

        public User() {
            this.Languages = new List<string>();
        }

    }
}
