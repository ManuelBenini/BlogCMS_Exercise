using System;
using System.Configuration;
using System.IO;

namespace SysDatCMS.Classes
{
    class DbHelper
    {
        public static string ConnStr = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public static string getRandomFileName(string fileName)
        {
            Random rd = new Random();
            string ext = Path.GetExtension(fileName);
            int randomNumber = rd.Next();

            return randomNumber + ext;
        }
    }
}
