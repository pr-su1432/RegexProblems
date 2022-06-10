namespace RegularExpressionTesting
{
    public class Tests
    {

        [Test]
        public void GivenFirstName_RegexFirstName_ReturnFirstName()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string firstName = "Prasanna";
            string actuvalResult = regex.RegexFirstNameChecker(firstName);
            Assert.Pass("Valid", actuvalResult);
        }
        [Test]
        public void GivenLastName_RegexLastName_ReturnLastName()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string lastName = "Kathi";
            string actuvalResult = regex.RegexLastNameChecker(lastName);
            Assert.Pass("Valid", actuvalResult);
        }
        [Test]
        public void GivenEmail_RegexEmail_ReturnEmail()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string email = "abc.@yahoo.com";
            string actuvalResult = regex.RegexEmail(email);
            Assert.Pass("Valid", actuvalResult);
        }
        [Test]
        public void GivenMobileNumber_RegexMobileNumber_ReturnMobileNumber()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string mobileNumber = "91 9182147305";
            string actuvalResult = regex.RegexMobileNumber(mobileNumber);
            Assert.Pass("Valid", actuvalResult);
        }
        [Test]
        public void GivenPassWord_RegexPassWord_ReturnPassWard()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string password = "Prasanna";
            string actuvalResult = regex.RegexPassword(password);
            Assert.Pass("Valid", actuvalResult);
        }
    }
}