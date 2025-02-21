using AlexisConstructionProject.Classes.functionsLogIn;
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

    public class Items
    {
        public static string[] services { get; set; }
        public static string[] tools { get; set; }
        public static int price { get; set; }
    }

    public class CreateUser
    {
        public static string username { get; set; }
        public static string password { get; set; }
        public static string fname { get; set; }
        public static string lname { get; set; }
        public static int age { get; set; }
        public static char gender { get; set; }
        public static byte[] Id { get; set; }
    }

    public class selectedItem
    {
        public static string service { get; set; }
        public static DateTime DateBooked { get; set; }
        public static int duration { get; set; }
        public static int Fee { get; set; }
        public static int TotalFee { get; set; }
    }

    public class Datagrid
    {

    }
}
