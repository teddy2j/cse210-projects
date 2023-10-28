public class ElderActive : Elder
{
    bool _hasGroup;

    public ElderActive(string name, string address) : base(name,address)
    {
        _hasGroup = false;

    }
    public override void AddToGroup()
    {
        _hasGroup = true;
    }

    public override void RemoveFromGroup()
    {
        _hasGroup = false;
    }

    public override bool HasGroup()
    {
        return _hasGroup;
    }

}