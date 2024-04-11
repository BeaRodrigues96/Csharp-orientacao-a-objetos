namespace CursoBalta.ContentContext
{
    public abstract class Content : Base/*é abstrato pois o conteudo precisa ser "algo", não pode ser instanciado de forma "vazia". 
    É uma classe privada pois somente os que irão derivar dele terão acesso ao conteudo, não podendo usar "new" nele, não podendo criar novo conteúdo.*/
    {

        public Content(string title, string url) //método construtor (ctor)
        {

            Title = title;
            Url = url;
        }

        public string Title { get; set; } = ""; 
        public string Url { get; set; } = ""; 
    }
}
