public class GuidService : IGuidServiceSingleton,IGuidServiceScoped, IGuidServiceTransient 
{
    private readonly string _guid;
    public GuidService()
    {
        _guid = Guid.NewGuid().ToString();
    }
    public string GetGuid()
    {
        return _guid;
    }
}