using static System.Net.Mime.MediaTypeNames;
using System;

namespace BlazorApp_UserInfo;

internal static class AppSettings
{
    internal static string DbConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Halaczkiewicz; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
}