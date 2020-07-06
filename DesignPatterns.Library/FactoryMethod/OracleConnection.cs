namespace DesignPatterns.Library.FactoryMethod
{
    public class OracleConnection : Connection
    {
        public override string Connect() {
            return "Succcesful connection to Oracle";
        }

        public override string Disconnect() {
            return "You have disconnected from Oracle";
        }
    }
}