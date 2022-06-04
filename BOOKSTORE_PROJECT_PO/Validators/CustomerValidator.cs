namespace BOOKSTORE_PROJECT_PO.Validators
{

    public class CustomerValidator : CommonValidator
    {
        public ValidateResult Validate(string firstName, string lastName, string email)
        {
            var firstNameResult = this.ValidateInput(firstName, "First Name", 30, 3);
            if (!firstNameResult.IsCorrect)
            {
                return firstNameResult;
            }

            var lastNameResult = this.ValidateInput(lastName, "Last Name", 30, 3);
            if (!lastNameResult.IsCorrect)
            {
                return lastNameResult;
            }

            var emailResult = this.ValidateInput(email, "Email", 50, 10);
            if (!emailResult.IsCorrect)
            {
                return emailResult;
            }

            return new ValidateResult { ErrorMessage = "", IsCorrect = true  };
        }
    }
}
