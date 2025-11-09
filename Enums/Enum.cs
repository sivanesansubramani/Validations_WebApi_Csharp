using System.ComponentModel;

namespace Validations_WebApi_Csharp.Enums
{
    public enum RolesEnom
    {
        Manager = 1,
        Level1 = 2,
        Level2 = 3,
        Worker = 4
    }

    public enum PasswordScore
    {
        [Description("Password is blank.")]
        Blank = 0,

        [Description("Very weak password. Try adding numbers or symbols.")]
        VeryWeak = 1,

        [Description("Weak password. Add uppercase letters or special characters.")]
        Weak = 2,

        [Description("Medium strength. Consider making it longer or adding more variation.")]
        Medium = 3,

        [Description("Strong password. Good mix of characters!")]
        Strong = 4,

        [Description("Very strong password! Excellent security.")]
        VeryStrong = 5
    }
}
