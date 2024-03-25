namespace Core.Persistence.Dynamic;

public class Filter
{
    public string Field { get; set; } //Filtre hangi alana uygulanacak
    public string Operator { get; set; } //Filtre operatörü (=, >, <, içinde geçen(contains) vs.)
    public string? Value { get; set; } //Filtre değeri
    public string? Logic { get; set; } //Filtre mantıksal operatörü (and, or, vs.)
    public IEnumerable<Filter>? Filters { get; set; } //Diğer filtreler

    public Filter()
    {
        Field = string.Empty;
        Operator = string.Empty;
    }

    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }
}
