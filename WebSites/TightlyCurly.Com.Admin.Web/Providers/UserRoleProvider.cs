using System;
using System.Web.Security;

namespace TightlyCurly.Com.Admin.Web.Providers
{
    public class UserRoleProvider : RoleProvider
    {
        private string _connectionName = String.Empty;

        public override string ApplicationName { get; set; }
       
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
            //if (usernames == null || usernames.Length == 0)
            //{
            //    throw new ArgumentNullException("usernames");
            //}

            //if (roleNames == null || roleNames.Length == 0)
            //{
            //    throw new ArgumentNullException("roleNames");
            //}
            //using (Context)
            //{
            //    foreach (string username in usernames)
            //    {
            //        if (!User.Exists(username))
            //        {
            //            throw new ProviderException("User not found");
            //        }

            //        var user = Context.Users.Single(u => u.Username == username);

            //        foreach (string roleName in roleNames)
            //        {
            //            if (!RoleExists(roleName))
            //            {
            //                throw new ProviderException("Role not found");
            //            }

            //            if (IsUserInRole(username, roleName))
            //            {
            //                throw new ProviderException("User already exists in role");
            //            }

            //            var role = Context.Roles.Single(r => r.RoleName == roleName);

            //            UsersRole usersRole = new UsersRole();
            //            usersRole.User = user;
            //            usersRole.Role = role;

            //            Context.UsersRoles.InsertOnSubmit(usersRole);
            //            Context.SubmitChanges();
            //        }
            //    }
            //}
        }
        
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(roleName))
            //{
            //    throw new ArgumentNullException("roleName");
            //}

            //if (RoleExists(roleName))
            //{
            //    throw new ProviderException("Role already exists");
            //}

            //using (Context)
            //{
            //    Role role = new Role();
            //    role.RoleName = roleName;

            //    Context.Roles.InsertOnSubmit(role);
            //    Context.SubmitChanges();
            //}
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(roleName))
            //{
            //    throw new ArgumentNullException("roleName");
            //}

            //if (!RoleExists(roleName))
            //{
            //    throw new ProviderException("Role not found");
            //}

            //bool deleted = false;

            //using (Context)
            //{
            //    var usersRoles = (from ur in Context.UsersRoles
            //                      where ur.Role.RoleName == roleName
            //                      select ur);

            //    var role = Context.Roles.Single(r => r.RoleName == roleName);

            //    Context.UsersRoles.DeleteAllOnSubmit(usersRoles);
            //    Context.Roles.DeleteOnSubmit(role);
            //    Context.SubmitChanges();

            //    deleted = true;
            //}

            //return deleted;
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(roleName))
            //{
            //    throw new ArgumentNullException(roleName);
            //}

            //if (String.IsNullOrEmpty(usernameToMatch))
            //{
            //    throw new ArgumentNullException(usernameToMatch);
            //}

            //if (!RoleExists(roleName))
            //{
            //    throw new ProviderException("Role not found");
            //}

            //string[] usernames = null;

            //using (Context)
            //{
            //    usernames = (from ur in Context.UsersRoles
            //                 where ur.User.Username.StartsWith(usernameToMatch) && ur.Role.RoleName == roleName
            //                 select ur.User.Username).ToArray();
            //}

            //return usernames;
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
            //string[] roles = null;

            //using (Context)
            //{
            //    roles = (from r in Context.Roles
            //             select r.RoleName).ToArray();
            //}

            //return roles;
        }

        public override string[] GetRolesForUser(string username)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //if (!User.Exists(username))
            //{
            //    throw new ProviderException("User not found");
            //}

            //string[] rolesForUser = null;

            //using (Context)
            //{
            //    rolesForUser = (from ur in Context.UsersRoles
            //                    where ur.User.Username == username
            //                    select ur.Role.RoleName).ToArray();
            //}

            //return rolesForUser;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(roleName))
            //{
            //    throw new ArgumentNullException("roleName");
            //}

            //if (!RoleExists(roleName))
            //{
            //    throw new ProviderException("Role not found");
            //}

            //string[] usersInRole = null;

            //using (Context)
            //{
            //    usersInRole = (from ur in Context.UsersRoles
            //                   where ur.Role.RoleName == roleName
            //                   select ur.User.Username).ToArray();
            //}

            //return usersInRole;
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(username))
            //{
            //    throw new ArgumentNullException("username");
            //}

            //if (String.IsNullOrEmpty(roleName))
            //{
            //    throw new ArgumentNullException("roleName");
            //}

            //if (!User.Exists(username))
            //{
            //    throw new ProviderException("User not found");
            //}

            //bool isUserInRole = false;

            //using (Context)
            //{
            //    isUserInRole = (from ur in Context.UsersRoles
            //                    where ur.User.Username == username && ur.Role.RoleName == roleName
            //                    select ur).Any();
            //}

            //return isUserInRole;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
            //if (usernames == null || usernames.Length == 0)
            //{
            //    throw new ArgumentNullException("usernames");
            //}

            //if (roleNames == null || roleNames.Length == 0)
            //{
            //    throw new ArgumentNullException("roleNames");
            //}
            //using (Context)
            //{
            //    foreach (string username in usernames)
            //    {
            //        if (!User.Exists(username))
            //        {
            //            throw new ProviderException("User not found");
            //        }

            //        var user = Context.Users.Single(u => u.Username == username);

            //        foreach (string roleName in roleNames)
            //        {
            //            if (!RoleExists(roleName))
            //            {
            //                throw new ProviderException("Role not found");
            //            }

            //            if (IsUserInRole(username, roleName))
            //            {
            //                throw new ProviderException("User already exists in role");
            //            }

            //            var role = Context.Roles.Single(r => r.RoleName == roleName);

            //            UsersRole usersRole = new UsersRole();
            //            usersRole.User = user;
            //            usersRole.Role = role;

            //            Context.UsersRoles.DeleteOnSubmit(usersRole);
            //            Context.SubmitChanges();
            //        }
            //    }
            //}
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(roleName))
            //{
            //    throw new ArgumentNullException("roleName");
            //}

            //bool exists = false;

            //using (Context)
            //{
            //    exists = (from r in Context.Roles
            //              where r.RoleName == roleName
            //              select r).Any();
            //}

            //return exists;
        }

        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            throw new NotImplementedException();
            //if (config == null)
            //{
            //    throw new ArgumentNullException("config");
            //}

            //if (String.IsNullOrEmpty(name))
            //{
            //    name = this.GetType().AssemblyQualifiedName;
            //}

            //if (String.IsNullOrEmpty(config["applicationName"]))
            //{
            //    ApplicationName = Constants.Defaults.DefaultApplicationName;;
            //}
            //else
            //{
            //    ApplicationName = config["applicationName"];
            //}

            //_connectionName = config["connectionStringName"];

            //base.Initialize(name, config);
        }
    }
}
