namespace ENSE707_Week1_Lab.Tests
{
    [TestClass]
    public sealed class BankAccountTests
    {
        [TestMethod]
        public void Deposit_PositiveAmount_IncreaseBalance()
        {
            BankAccount account = new BankAccount("test", 100);

            account.Deposit(50);

            Assert.AreEqual(150, account.Balance);
        }

        [TestMethod]
        public void Deposit_NegativeAmount_DecreaseBalance()
        {
            BankAccount account = new BankAccount("test", 100);

            account.Deposit(-50);

            Assert.AreEqual(50, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_DecreaseBalance()
        {
            BankAccount account = new BankAccount("test", 100);

            bool result = account.Withdraw(40);
            Assert.IsTrue(result);
            Assert.AreEqual(60, account.Balance);
        }

        [TestMethod]
        public void Withdraw_InvalidAmount_DecreaseBalance()
        {
            BankAccount account = new BankAccount("test", 100);

            bool result = account.Withdraw(500);
            Assert.IsTrue(result);
            Assert.AreEqual(60, account.Balance);
        }

        [TestMethod]
        public void Deposit_InvalidValue()
        {
            BankAccount account = new BankAccount("test", 0);

            Assert.ThrowsException<ArgumentException>(() =>
                account.Deposit(0));
        }

        [TestMethod]
        public void Account_CreateInvalidUserName()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new BankAccount("", 0));
        }

        [TestMethod]
        public void Account_CreateInvalidBalance()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new BankAccount("John Test", -100));
        }
    }
}
