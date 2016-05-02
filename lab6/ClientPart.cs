namespace lab6
{
    public partial class Client
    {
        public string GetFullName()
        {
            return string.Concat(LastName," ",FirstName, " ",Patronymic);
        }
    }
}
