namespace BOOKSTORE_PROJECT_PO.Validators
{
    public class AuthorValidator : CommonValidator
    {
        public ValidateResult Validate(string firstName, string lastName)
        {
            var firstNameResult = this.ValidateInput(firstName, "First Name", 30, 3);
            if (!firstNameResult.IsCorrect)
                return firstNameResult;

            var lastNameResult = this.ValidateInput(lastName, "Last Name", 30, 3);
            if (!lastNameResult.IsCorrect)
                return lastNameResult;

            return new ValidateResult { ErrorMessage = "", IsCorrect = true };
        }
    }
}
