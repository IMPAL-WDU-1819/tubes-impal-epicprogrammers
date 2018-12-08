using site;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
public class Globals
{
    public static readonly string STR_USER_ID_CONSUMER = "UserId_Consumer";
    public static readonly string STR_USER_ID_EMPLOYEE = "UserId_Employee";
    public static readonly string STR_LOGGED_AS = "Logged_As";
    public static readonly string STR_CONSUMER = "Consumer";
    public static readonly string STR_EMPLOYEE = "Employee";
    public static readonly string STR_ORDER_PLACED = "Order Placed";
    public static readonly string STR_ORDER_ACQUIRE_PARTS = "Telsa is acquiring parts for your car.";

    public static int GenerateRandomInt()
    {
        return new System.Random().Next();
    }
    public static bool isLoggedIn(string userid)
    {
        System.Diagnostics.Debug.WriteLine("=========DEBUG========" +  userid);
        var db = new teslaContext(); 
        var FindUser = db.Consumer.Where( x => userid == x.Email);
        return (FindUser.Count() == 1);
    }
    public static bool isLoggedInEmployee(string userid)
    {
        var db = new teslaContext(); 
        var FindUser = db.Employee.Where( x => userid == x.Email);
        return (FindUser.Count() == 1);
    }
}