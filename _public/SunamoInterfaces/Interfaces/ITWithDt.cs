namespace SunamoCompare._public.SunamoInterfaces.Interfaces;


public interface ITWithDt<T>
{
    T t { get; set; }
    DateTime Dt { get; set; }
}