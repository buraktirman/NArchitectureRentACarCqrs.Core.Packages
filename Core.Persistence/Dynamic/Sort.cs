namespace Core.Persistence.Dynamic;

public class Sort
{
    public string Field { get; set; } //Hangi alana göre sıralama yapılacak
    public string Dir { get; set; } //Sıralama yönü (asc, desc)

    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }

    public Sort(string field, string dir)
    {
        Field = field;
        Dir = dir;
    }
}
