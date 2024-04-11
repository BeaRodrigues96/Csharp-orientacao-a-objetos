namespace CursoBalta.NotificationContext
{
    public sealed class Notification // para que não sejam criadas variações dessa classe
    {
        public Notification()
        {

        }

        public Notification(string property, string messege)
        {
            Property = property;
            Messege = messege;
        }

        public string Property { get; set; }
        public string Messege { get; set; }
    }
}