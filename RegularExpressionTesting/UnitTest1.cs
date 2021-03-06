namespace RegularExpressionTesting
{
    public class Tests
    {

        /* [Test]
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
         }*/
        [Test]
        public void GetInvalidFirstName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string firstName = "prasanna...";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(firstName);
                string actual = regex.RegexNameChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
      //  [Test]
       /* public void GetInvalidLastName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string lastName = "kathi...";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(lastName);
                string actual = regex.RegexLastNameChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }*/
        [Test]
        public void GetInvalidEmail_checkRegexPattern_ShouldThrowInvalidEmailException()
        {
            try
            {
                string email = "xyz@abc@bl.com";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(email);
                string actual = regex.RegexEmail();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [Test]
        public void GetInvalidPhoneNumber_CheckRegexPattern_ShouldThrowInvalidNumberException()
        {
            try
            {
                string mobileNumber = "54564764544343";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(mobileNumber);
                string actual = regex.RegexMobileNumber();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid PhoneNumber", ex.Message);
            }
        }
        [Test]
        public void GetInvalidPassword_CheckRegexPattern_ShouldThrowInvalidPasswordException()
        {
            try
            {
                string password = "Summa@123#";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(password);
                string actual = regex.RegexPassword();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }
       
    }
}