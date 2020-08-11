namespace Employee.Entities
{
    /// <summary>
    /// <see cref="IPayable"/> is an interface that declares the <see cref="GetPaymentAmount"/> method.
    /// </summary>
    public interface IPayable
    {
        #region Methods
        double GetPaymentAmount(); 
        #endregion
    }
}