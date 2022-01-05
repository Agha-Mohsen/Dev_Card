namespace Dev.Models;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Descripton { get; set; }
    public string Image { get; set; }

    public Article(int id, string title, string descripton, string image)
    {
        Id = id;
        Title = title;
        Descripton = descripton;
        Image = image;
    }

}