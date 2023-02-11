using bankAccount.Class;


BankAccount diegoAlegre = new BankAccount();

diegoAlegre.bankNumbers = 123456789;
diegoAlegre.agency = 1234;
diegoAlegre.name = "Diego Alegre";
diegoAlegre.accountType = bankAccount.Class.Enum.AccountTypeEnum.SAVINGS;

diegoAlegre.InsertBalance(1000);

diegoAlegre.WithdrawBalance(900) ;

diegoAlegre.ShowBalance();
