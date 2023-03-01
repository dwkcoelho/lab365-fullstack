using bankAccounts.Class;
using bankAccounts.Class.Enum;

Client personLegal = new Client("Douglas Nascimento", DateTime.Parse("1990-01-25"), "Administrador", MaritalStatusEnum.MARRIED, TypePerson.LEGAL) ;
BusinessAccount businessAccount = new BusinessAccount(1542, 1234, personLegal, 1500, 10, "04528241000123");

businessAccount.MakeLoan(1200);
businessAccount.InsertBalance(200);
businessAccount.ShowBalance();
businessAccount.PayLoan();
businessAccount.ShowBalance();

Client personPhysical = new Client("Bruno Costa", DateTime.Parse("1999-01-25"), "Desenvolvedor", MaritalStatusEnum.DIVORCED, TypePerson.PHYSICAL);
CurrentAccount currentAccount = new CurrentAccount(1542, 1234, personPhysical);

currentAccount.InsertBalance(200);
currentAccount.WithdrawBalance(50);
currentAccount.ShowBalance();

SavingsAccount savingsAccount = new SavingsAccount(1542, 1234, personPhysical);

savingsAccount.InsertBalance(200);
savingsAccount.Transfer(currentAccount, 50);
savingsAccount.ShowBalance();