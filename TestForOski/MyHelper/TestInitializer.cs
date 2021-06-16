using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestForOski.Models;

namespace TestForOski.MyHelper
{
    // CreateDatabaseIfNotExists
    // DropCreateDatabaseAlways
    // DropCreateDatabaseIfModelChanges
    public class TestInitializer : DropCreateDatabaseAlways<TestContext>
    {
        // Заполнение локальной базы данных
        protected override void Seed(TestContext context)
        {
            context.Roles.Add(new Role { Id = 1, RoleName = "Зарегистрирован" });
            context.Roles.Add(new Role { Id = 2, RoleName = "Гость" });
         
            context.CategoryTests.Add(new CategoryTest
            { Id = 1, NameCategory = "Математика", IdRole = 1 });
            context.CategoryTests.Add(new CategoryTest
            { Id = 2, NameCategory = "Биология", IdRole = 1 });
            context.CategoryTests.Add(new CategoryTest
            { Id = 3, NameCategory = "Литература", IdRole = 2 });
          
            context.Questions.Add(new Question { Text = "Каков результат сложения: 2+2", IdCategory = 1 });
            context.Questions.Add(new Question { Text = "Выберите результат :3*5", IdCategory = 1 });
            context.Questions.Add(new Question { Text = "Выберите правильный вариант: 12/6", IdCategory = 1 });

            context.Questions.Add(new Question { Text = "Выберите Грызунов:", IdCategory = 2 });
            context.Questions.Add(new Question { Text = "Кто здесь Хищник ?", IdCategory = 2 });
            context.Questions.Add(new Question { Text = "Определите Парнокопытного", IdCategory = 2 });

            context.Questions.Add(new Question { Text = "Что написал  Лев Толстой ?", IdCategory = 3 });
            context.Questions.Add(new Question { Text = "Выберите рман Александра Дюма:", IdCategory = 3 });
            context.Questions.Add(new Question { Text = "Знаменитое произведение Федора Достоевского ?", IdCategory = 3 });
        
            base.Seed(context);
        
        }
    }
}
