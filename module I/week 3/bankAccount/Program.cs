using bankAccount.Class;


BankAccount diegoAlegre = new BankAccount(5343, 7655, "Diego Alegre", bankAccount.Class.Enum.AccountTypeEnum.SAVINGS);

diegoAlegre.InsertBalance(1000.50f);

diegoAlegre.WithdrawBalance(100.50f) ;

diegoAlegre.ShowBalance();

BankAccount diogoAlegre = new BankAccount(9595, 3214, "Diogo Alegre", bankAccount.Class.Enum.AccountTypeEnum.SAVINGS);

diogoAlegre.InsertBalance(200.00f);
diogoAlegre.Transfer(diegoAlegre, 100.00f);

diogoAlegre.ShowBalance();
diegoAlegre.ShowBalance();
