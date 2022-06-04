﻿namespace BOOKSTORE_PROJECT_PO.Validators
{
    public class ValidateResult
    {
        public bool IsCorrect { get; set; }    
        public string ErrorMessage { get; set; }    
    }
    public class CommonValidator
    { 
    
        protected ValidateResult ValidateInput(string text, string fieldName, int maxTextLenght, int minTextLenght)
        {
            if (text.Trim().Length == 0)
                return new ValidateResult { ErrorMessage = $"{fieldName} cannot be empty", IsCorrect = false };

            if (text.Trim().Length > maxTextLenght)
                return new ValidateResult { ErrorMessage = $"{fieldName} cannot be longer then {maxTextLenght} chars", IsCorrect = false };

            if (text.Trim().Length < minTextLenght)
                return new ValidateResult { ErrorMessage = $"{fieldName} too short. Minimal lenght is equal {minTextLenght}", IsCorrect = false};

            return new ValidateResult { ErrorMessage = "", IsCorrect = true  };
        }
    }
}
