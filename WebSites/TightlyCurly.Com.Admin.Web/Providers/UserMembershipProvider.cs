using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Web.Security;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Model;

namespace TightlyCurly.Com.Admin.Web.Providers
{
    public class UserMembershipProvider : MembershipProvider
    {
        #region Fields

        protected MembershipPasswordFormat _passwordFormat;

        private string _applicationName;
        private bool _enablePasswordReset;
        private bool _enablePasswordRetrieval;
        private bool _requiresQuestionAndAnswer;
        private bool _requiresUniqueEmail;
        private int _maxInvalidPasswordAttempts;
        private int _passwordAttemptWindow;
        private string _connectionName;
        private int _minRequiredNonAlphanumericCharacters;
        private int _minRequiredPasswordLength;
        private string _passwordStrengthRegularExpression;
        private bool _writeExceptionsToEventLog;

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public override int MinRequiredPasswordLength
        {
            get 
            { 
                return _minRequiredPasswordLength; 
            }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get 
            { 
                return _minRequiredNonAlphanumericCharacters; 
            }
        }

        public override string PasswordStrengthRegularExpression
        {
            get 
            { 
                return _passwordStrengthRegularExpression; 
            }
        }

        public override string ApplicationName
        {
            get 
            { 
                return _applicationName; 
            }
            set 
            {
                _applicationName = value; 
            }
        }

        public override bool EnablePasswordReset
        {
            get 
            { 
                return _enablePasswordReset; 
            }
        }

        public override bool EnablePasswordRetrieval
        {
            get 
            { 
                return _enablePasswordRetrieval; 
            }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get 
            { 
                return _requiresQuestionAndAnswer; 
            }
        }


        public override bool RequiresUniqueEmail
        {
            get 
            { 
                return _requiresUniqueEmail; 
            }
        }

        public override int MaxInvalidPasswordAttempts
        {
            get 
            { 
                return _maxInvalidPasswordAttempts; 
            }
        }

        public override int PasswordAttemptWindow
        {
            get 
            { 
                return _passwordAttemptWindow; 
            }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get 
            { 
                return _passwordFormat; 
            }
        }

        public bool WriteExceptionsToEventLog
        {
            get 
            { 
                return _writeExceptionsToEventLog; 
            }
            set 
            { 
                _writeExceptionsToEventLog = value; 
            }
        }

        #endregion

        #region Methods

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //if (String.IsNullOrEmpty(oldPassword))
            //{
            //    throw new ArgumentNullException("oldPassword");
            //}

            //if (String.IsNullOrEmpty(newPassword))
            //{
            //    throw new ArgumentNullException("newPassword");
            //}

            //if (!User.Exists(username))
            //{
            //    throw new MembershipPasswordException("User not found");
            //}

            //User.ChangePassword(username, EncodePassword(oldPassword), EncodePassword(newPassword));

            //return true;
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //if (String.IsNullOrEmpty(password))
            //{
            //    throw new ArgumentNullException("password");
            //}

            //if (String.IsNullOrEmpty(newPasswordQuestion))
            //{
            //    throw new ArgumentNullException("newPasswordQuestion");
            //}

            //if (String.IsNullOrEmpty(newPasswordAnswer))
            //{
            //    throw new ArgumentNullException("newPasswordAnswer");
            //}

            //if (!User.Exists(username))
            //{
            //    throw new MemberAccessException("User not found");
            //}

            //var user = User.GetUser(u => u.Username == username);

            //if (user != null)
            //{
            //    user.PasswordQuestion = newPasswordQuestion;
            //    user.PasswordAnswer = newPasswordAnswer;

            //    User.SaveUser(user);
            //}   

            //return true;
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
            //MembershipUser membershipUser = null;

            //if (String.IsNullOrEmpty(username))
            //{
            //    status = MembershipCreateStatus.InvalidUserName;
            //    return null;
            //}

            //if (User.Exists(username))
            //{
            //    status = MembershipCreateStatus.DuplicateUserName;
            //    return null;
            //}

            //if (String.IsNullOrEmpty(password))
            //{
            //    status = MembershipCreateStatus.InvalidPassword;
            //    return null;
            //}

            //if (String.IsNullOrEmpty(email))
            //{
            //    status = MembershipCreateStatus.InvalidEmail;
            //    return null;
            //}

            //if (RequiresUniqueEmail && EmailExists(email))
            //{
            //    status = MembershipCreateStatus.DuplicateEmail;
            //    return null;
            //}

            //if (String.IsNullOrEmpty(passwordQuestion))
            //{
            //    status = MembershipCreateStatus.InvalidQuestion;
            //    return null;
            //}

            //if (String.IsNullOrEmpty(passwordAnswer))
            //{
            //    status = MembershipCreateStatus.InvalidAnswer;
            //    return null;
            //}

            //try
            //{
            //    User user = User.CreateUser(username, EncodePassword(password), email, passwordQuestion, passwordAnswer, isApproved);
            //    membershipUser = MembershipUserFromUser(user);
            //}
            //catch (Exception)
            //{
            //    status = MembershipCreateStatus.ProviderError;
            //    throw;
            //}

            //status = MembershipCreateStatus.Success;
            //return membershipUser;
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //bool deleted = false;

            //User user = User.GetUser(u => u.Username == username);

            //if (user != null)
            //{
            //    User.DeleteUser(user);
            //    deleted = true;
            //}

            //return deleted;
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(emailToMatch))
            //{
            //    totalRecords = 0;
            //    throw new ArgumentNullException("emailToMatch");
            //}
            
            //MembershipUserCollection membershipUsers = new MembershipUserCollection();

            //var users = User.GetUsers(u => u.EmailAddress == emailToMatch);

            //foreach (var user in users)
            //{
            //    membershipUsers.Add(MembershipUserFromUser(user));
            //}

            //totalRecords = membershipUsers.Count;
            //return membershipUsers;
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(usernameToMatch))
            //{
            //    totalRecords = 0;
            //    throw new ArgumentNullException("usernameToMatch");
            //}

            //MembershipUserCollection membershipUsers = new MembershipUserCollection();

            //var users = User.GetUsers(u => u.Username == usernameToMatch);

            //foreach (var user in users)
            //{
            //    membershipUsers.Add(MembershipUserFromUser(user));
            //}

            //totalRecords = membershipUsers.Count;
            //return membershipUsers;
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
            //MembershipUserCollection users = new MembershipUserCollection();

            //var usersInSystem = User.GetAllUsers();

            //foreach (var user in usersInSystem)
            //{
            //    users.Add(MembershipUserFromUser(user));
            //}

            //totalRecords = users.Count;

            //return users;
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException("Not Supported");
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException("Not Supported");
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //if (!User.Exists(username))
            //{
            //    return null;
            //}

            //return MembershipUserFromUser(User.GetUser(u => u.Username == username));
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
            //int userId = Int32.Parse(providerUserKey.ToString());

            //if (!User.Exists(userId))
            //{
            //    return null;
            //}

            //return MembershipUserFromUser(User.GetUser(u => u.UserId == userId));

        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(email))
            //{
            //    throw new ArgumentNullException("email");
            //}

            //return User.GetUser(u => u.EmailAddress == email).Username;
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //if (RequiresQuestionAndAnswer && String.IsNullOrEmpty(answer))
            //{
            //    throw new ArgumentNullException("answer");
            //}

            //string password = null;

            //var user = User.GetUser(u => u.Username == username && u.PasswordAnswer == answer);

            //if (user != null)
            //{
            //    throw new MembershipPasswordException("Could not locate user, or the supplied answer is incorrect.");
            //}

            //password = Membership.GeneratePassword(_minRequiredPasswordLength, _minRequiredNonAlphanumericCharacters);

            //if (user.IsLockedOut.HasValue && user.IsLockedOut.Value)
            //{
            //    throw new MembershipPasswordException("Cannot reset password.  User is locked out.");
            //}

            //user.Password = EncodePassword(password);
            //user.LastPasswordChangedDate = DateTime.Now;
            //user.LastActivityDate = DateTime.Now;

            //User.SaveUser(user);

            //return password;
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(userName))
            //{
            //    throw new ArgumentNullException("userName");
            //}

            //bool unlocked = false;

            //var user = User.GetUser(u => u.Username == userName);

            //if (user != null)
            //{
            //    user.IsLockedOut = false;
            //    unlocked = true;
            //}

            //return unlocked;
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException("user");
        //    }

        //    User dbUser = User.GetUser(u => u.UserId == Int32.Parse(user.ProviderUserKey.ToString()));
            
        //    if (dbUser == null)
        //    {
        //        throw new ArgumentException("User doesn't exist");
        //    }

        //    dbUser.IsApproved = user.IsApproved;
        //    dbUser.EmailAddress = user.Email;
        //    dbUser.Comment = user.Comment;
        //    dbUser.IsApproved = user.IsApproved;
               
        //    User.SaveUser(dbUser);
        }

        public override bool ValidateUser(string username, string password)
        {
            throw new NotImplementedException();
           // return User.Exists(username, EncodePassword(password));
        }

        public override void Initialize(string name, NameValueCollection config)
        {
            //if (config == null)
            //{
            //    throw new ArgumentNullException("config");
            //}

            //if (String.IsNullOrEmpty(name))
            //{
            //    name = this.GetType().AssemblyQualifiedName;
            //}

            //base.Initialize(name, config);

            //InitializeValues(name, config);
        }

        #region Helper Methods

        //protected void InitializeValues(string name, NameValueCollection config)
        //{
        //    _applicationName = GetConfigValue(config["applicationName"],
        //                                    System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath);

        //    _maxInvalidPasswordAttempts = Convert.ToInt32(GetConfigValue(config["maxInvalidPasswordAttempts"], "5"));
        //    _passwordAttemptWindow = Convert.ToInt32(GetConfigValue(config["passwordAttemptWindow"], "10"));
        //    _minRequiredNonAlphanumericCharacters = Convert.ToInt32(GetConfigValue(config["minRequiredNonAlphanumericCharacters"], "1"));
        //    _minRequiredPasswordLength = Convert.ToInt32(GetConfigValue(config["minRequiredPasswordLength"], "7"));
        //    _passwordStrengthRegularExpression = Convert.ToString(GetConfigValue(config["passwordStrengthRegularExpression"], ""));
        //    _enablePasswordReset = Convert.ToBoolean(GetConfigValue(config["enablePasswordReset"], "true"));
        //    _enablePasswordRetrieval = Convert.ToBoolean(GetConfigValue(config["enablePasswordRetrieval"], "true"));
        //    _requiresQuestionAndAnswer = Convert.ToBoolean(GetConfigValue(config["requiresQuestionAndAnswer"], "false"));
        //    _requiresUniqueEmail = Convert.ToBoolean(GetConfigValue(config["requiresUniqueEmail"], "true"));
        //    _writeExceptionsToEventLog = Convert.ToBoolean(GetConfigValue(config["writeExceptionsToEventLog"], "true"));

        //    _passwordFormat = GetFormatFromString(config["passwordFormat"]);
        //    _connectionName = config["connectionStringName"];
        //}

        //protected bool EmailExists(string emailAddress)
        //{
        //    return (User.GetUser(u => u.EmailAddress == emailAddress) != null);
        //}

        //protected string GetConfigValue(string configValue, string defaultValue)
        //{
        //    return String.IsNullOrEmpty(configValue) ? defaultValue : configValue;
        //}

        //protected string EncodePassword(string password)
        //{
        //    string encodedPassword = password;

        //    switch (PasswordFormat)
        //    {
        //        case MembershipPasswordFormat.Hashed:
        //            encodedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(encodedPassword, Constants.Defaults.DefaultHashingAlgorithm);
        //            break;
        //        default:
        //            throw new MembershipPasswordException("Unsupported password format.");
        //    }

        //    return encodedPassword;
        //}

        //protected MembershipPasswordFormat GetFormatFromString(string format)
        //{
        //    if (String.IsNullOrEmpty(format))
        //    {
        //        return MembershipPasswordFormat.Hashed;
        //    }

        //    switch (format)
        //    {
        //        case "Hashed":
        //            return MembershipPasswordFormat.Hashed;
        //            break;
        //        default:
        //            throw new MembershipPasswordException("Password format not supported.");
        //    }
        //}

        //protected MembershipUser MembershipUserFromUser(User user)
        //{
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException("user");
        //    }

        //    MembershipUser membershipUser = new MembershipUser(
        //        this.Name, 
        //        user.Username, 
        //        user.UserId, 
        //        user.EmailAddress, 
        //        user.PasswordQuestion, 
        //        user.Comment, 
        //        user.IsApproved.HasValue ? user.IsApproved.Value : true,
        //        user.IsLockedOut.HasValue ? user.IsLockedOut.Value : false, 
        //        user.CreationDate.HasValue ? user.CreationDate.Value : DateTime.MinValue, 
        //        user.LastLoginDate.HasValue ? user.LastLoginDate.Value : DateTime.MinValue, 
        //        user.LastActivityDate.HasValue ? user.LastActivityDate.Value : DateTime.MinValue, 
        //        user.LastActivityDate.HasValue ? user.LastPasswordChangedDate.Value : DateTime.MinValue, 
        //        user.LastLockoutDate.HasValue ? user.LastLockoutDate.Value : DateTime.MinValue);

        //    return membershipUser;
        //}
        
        #endregion

        #endregion
    }
}
