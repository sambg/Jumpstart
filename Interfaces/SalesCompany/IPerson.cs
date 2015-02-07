namespace SalesCompany
{
    public interface IPerson
    {
        string Name { get; }
        string Family { get; }
        int EGN { get; }
        string GetInfo();
    }
}
