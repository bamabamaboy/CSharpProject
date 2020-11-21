using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models {
    public class ArticlesModel {

        public string header;
        public string text;
        public string author;

        public ArticlesModel(string header, string text, string author) {
            this.header = header;
            this.text = text;
            this.author = author;
        }
    }
}