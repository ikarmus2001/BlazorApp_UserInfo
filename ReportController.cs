using BlazorApp_UserInfo.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_UserInfo;

internal class ReportController
{
    private AppDbContext _context;

    internal ReportController(AppDbContext c)
    {
        _context = c;
    }

    internal Stream GenerateReport()
    {
        string content = GetCsvHeader();
        foreach (AppUser u in _context.Users.ToList())
        {
            content += u.Title() + "," + u.Name + "," + u.Surname + "," + u.Birthdate.ToString("dd.MM.yyyy") + "," + u.Age() + Environment.NewLine;
        }

        byte[] generated = content.ToCharArray().Select(c => (byte)c).ToArray();
        return new MemoryStream(generated);
        
    }

    private static string GetCsvHeader() => "Title,Name,Surname,Birthdate,Age" + Environment.NewLine;
}
