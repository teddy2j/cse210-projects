public class ElderInactive : Elder
{
    public ElderInactive(string name, string address) : base(name, address)
    {

    }
    public override bool HasGroup()
    {
        return true;  //inactive elders don't ministrate, so they are treated as if they always had a group//
    }

    public override void AddToGroup()
    {
        
    }
    public override void RemoveFromGroup()
    {

    }


}