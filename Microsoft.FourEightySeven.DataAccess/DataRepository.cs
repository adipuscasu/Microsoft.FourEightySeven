using Microsoft.FourEightySeven.DataModel;

namespace Microsoft.FourEightySeven.DataAccess
{
    public static class DataRepository
    {
        public static Account[] Accounts = {
            new Account {AccountId = 1, AccountAlias = "Disney"},
            new Account {AccountId = 2, AccountAlias = "Marvel"},
            new Account {AccountId = 3, AccountAlias = "McDonald's"},
            new Account {AccountId = 4, AccountAlias = "Flintstones"}
        };

        public static Customer[] Customers = {
            new Customer {CustomerId = 1, AccountId = 1, FirstName = "Mickey", LastName = "Mouse"},
            new Customer {CustomerId = 2, AccountId = 1, FirstName = "Minnie", LastName = "Mouse"},
            new Customer {CustomerId = 3, AccountId = 1, FirstName = "Donald", LastName = "Duck"},
            new Customer {CustomerId = 4, AccountId = 2, FirstName = "Captain", LastName = "America"},
            new Customer{ AccountId = 2, CustomerId = 5,
                FirstName = "Spider", LastName = "Man"},
            new Customer{ AccountId = 2, CustomerId = 6,
                FirstName = "Wolverine", LastName = "N/A"},
            new Customer{ AccountId = 3, CustomerId = 7,
                FirstName = "Ronald", LastName = "McDonald"},
            new Customer{ AccountId = 3, CustomerId = 8,
                FirstName = "Ham", LastName = "Burgler"},
            new Customer{ AccountId = 4, CustomerId = 9,
                FirstName = "Fred", LastName = "Flintstone"},
            new Customer{ AccountId = 4, CustomerId = 10,
                FirstName = "Wilma", LastName = "Flintstone"},
            new Customer{ AccountId = 4, CustomerId = 11,
                FirstName = "Betty", LastName = "Rubble"},
            new Customer{ AccountId = 4, CustomerId = 12,
                FirstName = "Barney", LastName = "Rubble"}
        };
    }
}
