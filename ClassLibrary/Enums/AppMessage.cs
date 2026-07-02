using System.ComponentModel;

namespace ClassLibrary.Enums
{
    public enum AppMessage
    {
        [Description("You successfully registered a new account")]
        RegistrationSuccess,

        [Description("Passwords do not match")]
        RegistrationDiffentPasswords,

        [Description("Email already registered")]
        RegistrationEmailAlredyRegistered,

        [Description("Ivalid email")]
        RegistrationInvalidEmail,

        [Description("Incorect email or/and password")]
        LoginFailed
    };
}