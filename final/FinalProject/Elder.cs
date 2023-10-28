using System.Net.Sockets;

public abstract class Elder
{
    protected string _name;
    protected string _address;
    protected bool _isMinistered;

    public Elder(string name, string address)
    {
        _name=name;
        _address=address;

    }

    public string GetDetailsString()
    {
        return $"{_name}, {_address}";
    }

    public bool IsMinistered()
    {
        return _isMinistered;
    }
    public void GiveMinisterBrothers()
    {
        _isMinistered = true;
    }

    public void RemoveMinisterBrothers()
    {
        _isMinistered = false;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void AddToGroup();
    public abstract void RemoveFromGroup();
    public abstract bool HasGroup();








}

