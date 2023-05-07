using BankInformation;

namespace BankInformationTest
{
    public class BankInfoTest
    {
        [Fact]
        public void Adding_Funds_Update_Balance()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act
            account.AddBalance(100);

            // Assert
            Assert.Equal(1100, account.Balance);
        }

        [Fact]
        public void Adding_Funds_Negative_Exception()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.AddBalance(-100));
        }

        [Fact]
        public void Withdraw_Funds_Update_Balance()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act
            account.Withdraw(100);

            // Assert
            Assert.Equal(900, account.Balance);
        }

        [Fact]
        public void Withdraw_Funds_Negative_Exception()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-100));
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(2000));
        }

        [Fact]
        public void TransferFundTo()
        {
            // Arrange
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount();

            // Act
            account.TransferFundsTo(otherAccount, 500);

            // Assert
            Assert.Equal(otherAccount.Balance, account.Balance);
        }
    }
}