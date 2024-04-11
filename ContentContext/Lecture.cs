using CursoBalta.ContentContext.Enums;

namespace CursoBalta.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; } = ""; //Ou, em vez de "" também podemos usar string.Empty. Estava dando erro, e esta foi uma forma de consertar, pois a propriedade não são anuláveis (nullable), mas não têm um valor padrão definido.
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}