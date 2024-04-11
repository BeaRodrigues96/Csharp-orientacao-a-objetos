using CursoBalta.NotificationContext;

namespace CursoBalta.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso Inválido"));
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; } = ""; //Ou, em vez de "" também podemos usar string.Empty. Estava dando erro, e esta foi uma forma de consertar, pois a propriedade não são anuláveis (nullable), mas não têm um valor padrão definido.
        public string Description { get; set; } = ""; //Ou, em vez de "" também podemos usar string.Empty. Estava dando erro, e esta foi uma forma de consertar, pois a propriedade não são anuláveis (nullable), mas não têm um valor padrão definido.
        public Course Course { get; set; }
    }
}