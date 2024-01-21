namespace Facade.BackOffice
{
    public class SecurityCodeChecker
    {
        public int SecurityCode { get; } = 1234;

        public bool IsSecurityCodeOk(int securityCode)
        {
            return securityCode == SecurityCode;
        }
    }
}
