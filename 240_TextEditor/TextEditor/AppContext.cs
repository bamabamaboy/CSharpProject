using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;       //Сама база данных, технология с помощью которой мы работаем с БД

namespace TextEditor {
    class AppContext : DbContext {
        
        //Обращаясь к данной переменной, я обращаюсь напрямую к табличке users в БД
        public DbSet<User> Users { get; set; }       //Обязательно с большой буквы

        //При создании объекта класса AppContext будем в автоматическом режиме подключаться к нашей БД
        public AppContext() : base("DefaultConnection") { }

    }
}
