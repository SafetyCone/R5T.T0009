using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0009
{
    [StrongTypeMarker]
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
