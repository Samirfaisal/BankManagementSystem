namespace BankManagementSystem.App
{
    internal class DataBaseAccessBase
    {
        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { this.sqlcon = value; }
        }
    }
}