using System;

using R5T.Stagira;


namespace R5T.T0009
{
    public class UserName : TypedString
    {
        #region Static

        public static UserName From(string userNameValue)
        {
            var userName = new UserName(userNameValue);
            return userName;
        }

        #endregion


        public UserName(string value)
            : base(value)
        {
        }
    }
}
