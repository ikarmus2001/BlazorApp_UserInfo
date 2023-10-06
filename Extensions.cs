using BlazorApp_UserInfo.Data.Transient;
using BlazorApp_UserInfo.Data.Model;

namespace BlazorApp_UserInfo
{
    internal static class Extensions
    {
        internal static UserProperties ToUserProperty(this UserProp input)
        {
            return new UserProperties
            {
                PropertyId = input.PropertyId,
                UserId = input.UserId,
                Value = input.Value
            };
        }
    }
}
