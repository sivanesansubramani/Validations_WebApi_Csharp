using System.Collections.Generic;
using System.Text.RegularExpressions;
using Validations_WebApi_Csharp.Models;
using Validations_WebApi_Csharp.Enums;
using System.ComponentModel;

namespace Validations_WebApi_Csharp.Repository
{
    public class Validator
    {
        public List<ErrorDetails> NewUserValidator(MemoryValidations Datamodel)
        {
            var errorlist = new List<ErrorDetails>();

            if(string.IsNullOrWhiteSpace(Datamodel.Name))
            {
                errorlist.Add(new ErrorDetails {PropertyName = "Name",ErrorIdentifier = "001",ErrorMessage="User Name is Required" });
            }
            if(Datamodel.Name.Length >= 15)
            {
                errorlist.Add(new ErrorDetails { PropertyName = "Name", ErrorIdentifier = "002", ErrorMessage = "Name is not greater than 15" });
            }
            if(Datamodel.Name.Any(c => !char.IsLetterOrDigit(c)))
            {
                errorlist.Add(new ErrorDetails { PropertyName = "Password", ErrorIdentifier = "004", ErrorMessage = "Name does not contains special character" });
            }

            var checkScore = PasswordValidator(Datamodel.Password);

            if (checkScore != PasswordScore.Strong)
            {
                var field = checkScore.GetType().GetField(checkScore.ToString());
                var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

                errorlist.Add(new ErrorDetails
                {
                    PropertyName = "Name",
                    ErrorIdentifier = "003",
                    ErrorMessage = attribute?.Description ?? checkScore.ToString()
                });
            }

            return errorlist;
        }

         

        public static PasswordScore PasswordValidator(string?  Password)
        {
            int PassScore = 0;

            if(string.IsNullOrWhiteSpace(Password))
            {
                return PasswordScore.Blank;
            }

            if(Password.Length <= 4)
            {
                return PasswordScore.Weak;
            }
            if(Password.Length >=8)
            {
                PassScore++;
            }
            if (Password.Length >= 12)
            {
                PassScore++;
            }
            if (Regex.Match(Password, @"/\d+/", RegexOptions.ECMAScript).Success)
                PassScore++;
            if (Regex.Match(Password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
              Regex.Match(Password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
                PassScore++;
            if (Regex.Match(Password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
                PassScore++;

            return (PasswordScore)PassScore;
                
        }
    }
}
