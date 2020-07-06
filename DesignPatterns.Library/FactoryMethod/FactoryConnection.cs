namespace DesignPatterns.Library.FactoryMethod
{
    public class FactoryConnection
    {
        public static Connection GetConnection(string motor) 
        {
            switch (motor)
            {
                case "SQL":
                    return new SqlConnection();
                    break;
                case "ORACLE":
                    return new OracleConnection();
                    break;
                default: 
                    return null;
            }
        }
    }
}