using System.Collections.Generic;
using System.ComponentModel.Design;
using CursoBalta.ContentContext;

namespace CursoBalta
{
    public class Program
    {
        static void Main(string[] args)
        {

            var articles = new List<Article>();
            //sempre que tivermos um Article, ele vai esperar um título e uma url
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre Frameworks", "dotnet"));
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            // Lista de Cursos
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-c#");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            // Carreiras
            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .Net", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda Dotnet", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda Dotnet", "", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);
            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Messege}");
                    }
                }
            }
        }



    }
}

