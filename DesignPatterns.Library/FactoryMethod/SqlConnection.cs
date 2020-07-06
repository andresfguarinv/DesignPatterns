namespace DesignPatterns.Library.FactoryMethod
{
    public class SqlConnection : Connection
    {
        public override string Connect() {
            return "Succcesful connection to Sql Server";
        }

        public override string Disconnect() {
            return "You have disconnected from Sql Server";
        }
    }
}