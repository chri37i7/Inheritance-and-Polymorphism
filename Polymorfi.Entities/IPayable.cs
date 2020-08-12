namespace Polymorfi.Entities
{
    public interface IPayable
    {
        bool IsProcessed { get; set; }

        decimal GetAmount();
    }
}