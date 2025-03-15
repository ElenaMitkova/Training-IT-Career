using PersonAndHisMoney;

Person firstPerson = new Person();
Person secondPerson = new Person();
Person thirdPerson = new Person();
firstPerson.BankAccounts.Add(new BankAccount { Id = 1, Balance = 15.5m });
secondPerson.BankAccounts.Add(new BankAccount { Id = 1, Balance = 15.5m });
secondPerson.BankAccounts.Add(new BankAccount { Id = 2, Balance = 25.5m });
thirdPerson.BankAccounts.Add(new BankAccount { Id = 1, Balance = 15.5m });
thirdPerson.BankAccounts.Add(new BankAccount { Id = 2, Balance = 25.5m });
thirdPerson.BankAccounts.Add(new BankAccount { Id = 3, Balance = 35.5m });
Console.WriteLine(firstPerson.GetBalance());
Console.WriteLine(secondPerson.GetBalance());
Console.WriteLine(thirdPerson.GetBalance());