namespace QSS.eIQC.Handlers.Common
{
    internal class Constants
    {
        internal static class ValidationErrors
        {
            private static string _propertyName = "{PropertyName}";

            internal static string PropertyMustBeProvided => "{PropertyName} must be provided";

            internal static string PropertyCannotBeEmpty => "{PropertyName} can not be empty";

            internal static string PropertyCannotExceedCharacters(int length) => _propertyName + string.Format(" can not be exceed {0} characters", length);

        }


        internal static class CustomValidationErrors
        {
            internal static string IPAlreadyExists => "Inspection Plan already exists for the given Part No and Manufacture Part Number. Please specify different value";
        }
    }
}
