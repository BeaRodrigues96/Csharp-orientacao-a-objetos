using System;
using System.Collections.Generic;
using CursoBalta.ContentContext.Enums;

namespace CursoBalta.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) // para que não sejam nulos, é esperado um valor para title e url; base é pq esse conteudo deriva de Content
        : base(title, url)
        {
            Modules = new List<Module>(); //Criado um ctor para inicialização dos módulos
        }
        public string Tag { get; set; } = ""; //Tag dos cursos
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }

}
