namespace MISA.UT.WS.AppConsole.Payment
{
    public interface IPaymentService
    {
        PaymentResult Create(PaymentDto payment);
    }
}