using System.Collections.Generic;

namespace CursoBalta.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; } = ""; //Ou, em vez de "" também podemos usar string.Empty. Estava dando erro, e esta foi uma forma de consertar, pois a propriedade não são anuláveis (nullable), mas não têm um valor padrão definido.
        public IList<Lecture> Lectures { get; set; }
    }
}