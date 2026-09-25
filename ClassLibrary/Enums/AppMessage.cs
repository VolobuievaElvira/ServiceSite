using System.ComponentModel;

namespace ClassLibrary.Enums
{
    public enum AppMessage
    {
        [Description("You successfully registered a new account")]
        RegistrationSuccess,

        [Description("Passwords do not match")]
        RegistrationDifferentPasswords,

        [Description("Email already registered")]
        RegistrationEmailAlredyRegistered,

        [Description("Invalid email")]
        RegistrationInvalidEmail,

        [Description("Incorrect email or/and password")]
        LoginFailed,

        [Description("You successfully logged in")]
        LoginSuccess,

        [Description("You successfully logged out")]
        LogoutSuccess,

        [Description("You successfully updated your profile")]
        ProfileUpdateSuccess,

        [Description("You successfully created a new order")]
        OrderCreationSuccess,

        [Description("You successfully updated the order status")]
        OrderStatusUpdateSuccess,

        [Description("The order was successfully accepted")]
        OrderAcceptedSuccess,

        [Description("The order was successfully completed")]
        OrderCompletedSuccess,

        [Description("The order was successfully canceled")]
        OrderCanceledSuccess,

        [Description("The master is not qualified")]
        MasterNotQualified,

        [Description("The order is already completed")]
        OrderAlreadyCompleted,

        [Description("The order is already canceled")]
        OrderAlreadyCanceled,

        [Description("The order is already accepted")]
        OrderAlreadyTaken,

        [Description("The service description is too short")]
        ServiceDescriptionIsTooShort,

        [Description("The price must be greater than zero")]
        PriceIsLessOrEqualZero
    };
}