using System.Collections.Generic;
using CursoBalta.NotificationContext;
namespace CursoBalta.ContentContext
{
    public class Article : Content
    {
        public IList<Notification> Notifications { get; set; }
        public Article(string title, string url)
        : base(title, url)
        {

        }
    }
}