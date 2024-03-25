namespace Core.Persistence.Paging;

public interface IPaginate<T>
{
    int From { get; }
    int Index { get; } //Hangi sayfadayız (0'dan başlar)
    int Size { get; } //Sayfada kaç veri olacak
    int Count { get; } //Toplam veri sayısı
    int Pages { get; } //Toplam sayfa sayısı
    IList<T> Items { get; }
    bool HasPrevious { get; }
    bool HasNext { get; }
}
