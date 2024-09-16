namespace travel_api.Infrastructure
{
    public static class CustomMessage
    {
        public const string API_SECRET_KEY = "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING,BANK STATE";
        public const string NO_RECORD_FOUND = "No Record Found.";
        public const string COMMON_ERROR = "Cannot be complete your request.";
        public const string ACCOUNT_DEACTIVE = "Your account de-activated by system Admin.";
        public const string ACCOUNT_PENDING = "Your account is currently pending approval by Admin";
        public const string USER_CREDENTIAL = "Invalid user credentials";
        public const string EMAIL_SENT = "New password sent to the Email.";
        public const string EMAIL_SENT_RESET_PASSWORD = "Password reset link sent to the Email.";
        public const string RESET_PASSWORD_LINK_INVALIED = "Invalid password reset link.";
        public const string INFORMATION_SAVE = "User updated.";
        public const string INFORMATION_SAVE_ERROR = "Current user not updated.";
        public const string PASSWORD_SAVE = "Password Changed.";
        public const string PASSWORD_ERROR = "Existing password not valid.";
        public const string EMAIL_SAVE = "Email address Changed.";
        public const string EMAIL_ERROR = "Email address not available.";
        public const string EMPLOYEE_CODE_INVALID = "Employee code not valid.";
        public const string USERLEVEL_SUCCESS_INSERT = "Userlevel created.";
        public const string USERLEVEL_ERROR_INSERT = "Userlevel cannot be created.";
        public const string USERLEVEL_ALREADY_ERROR_INSERT = " Userlevel already created.";
        public const string USERLEVEL_EMPTY_ERROR_INSERT = "Userlevel cannot be empty.";
        public const string USERLEVEL_SUCCESS_UPDATE = "Userlevel updated.";
        public const string USERLEVEL_ERROR_UPDATE = "Userlevel cannot be updated.";
        public const string USERLEVEL_USER_ERROR_DELETE = "Cannot be delete userlevel until delete accessible users.";
        public const string USER_CREATED = "System User Created.";
        public const string USER_UPDATE_ERROR = "Cannot be update system User.";
        public const string USER_UPDATE_SUCCESS = "System User Updated.";
        public const string USER_DELETE_ERROR = "Cannot be delete system User.";
        public const string USER_DELETE_SUCCESS = "System User deleted.";
        public const string USER_EXISTING_FAULT = "Username already existing.";

        public const string ACCOUNT_UNIQUE = "This account type cannot be delete or modify anymore.";
        public const string ACCOUNT_INVALID = "Account Type not valid.";
        public const string ACCOUNT_DELETE_FAULT = "Account cannot be deleted.";
        public const string ACCOUNT_DELETE_SUCCESS = "Account deleted.";
        public const string ACCOUNT_UPDATED = "Account Updated.";
        public const string ACCOUNT_INSERT = "Account Created.";
        public const string DESIGNATION_ERROR = "Invalid designation.";
        public const string DESIGNATION_DELETED = "Designation deleted.";
        public const string DESIGNATION_UPDATED = "Designation updated.";
        public const string DESIGNATION_INSERT = "Designation saved.";
        public const string DESIGNATION_DELETE_FAULT = "Designation cannot be deleted.";
        public const string DESIGNATION_UPDATE_ERROR = "Designation cannot be updated.";
        public const string DESIGNATION_INSERT_ERROR = "Cannot be add new Designation.";
        public const string ACCOUNT_EXISTING_FAULT = "Account already existing.";
        public const string ACCOUNT_REGISTER_USER_FAULT = "Users already assign with this an account type.";
        public const string ACCOUNT_SYSTEM_FAULT = "System already existing with this an account type.";

        public const string FILE_EXTENSION_INVALID_EXCEL = "File Extension Is InValid - Only Upload EXCEL File";

        public const string RECORD_ADDED_SUCCESS = "Record added";
        public const string RECORD_UPDATED_SUCCESS = "Record updated";

        public const string FILE_ALREADY_EXIST = "File name already exists.";
    }
}
