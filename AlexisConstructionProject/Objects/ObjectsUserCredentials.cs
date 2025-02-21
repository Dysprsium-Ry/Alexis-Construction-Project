using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexisConstructionProject.Objects
{
    public class UserCredentials
    {
        public static long ID { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string FName { get; set; }
        public static string LName { get; set; }
        public static int age { get; set; }
        public static char gender { get; set; }
        public static byte[] ProfileImage { get; set; }
    }

    public class Validities
    {
        public static bool isValid { get; set; }
        public static bool isPresent { get; set; }
    }
}
