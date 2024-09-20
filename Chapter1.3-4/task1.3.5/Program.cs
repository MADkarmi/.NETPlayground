using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var userdata = File.ReadAllLines(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\bin\Debug", @"\Data\UserData.txt"));
            var useraccounts = File.ReadAllLines(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\bin\Debug", @"\Data\Accounts.txt"));

            var datalist = from line in userdata
                           select new { imie = line.Split(',')[0], nazwisko = line.Split(',')[1], PESEL = line.Split(',')[2] };
            var accountlist = from line in useraccounts
                              select new { PESEL = line.Split(',')[0], NrKonta = line.Split(',')[1]};

            var AccountDatabase = from userdt in datalist
                                  join accountnbr in accountlist
                                  on userdt.PESEL equals accountnbr.PESEL
                                  select new
                                  {
                                      name = userdt.imie,
                                      surname = userdt.nazwisko,
                                      pesel = userdt.PESEL,
                                      account = accountnbr.NrKonta
                                  };

            foreach (var user in AccountDatabase)
                Console.WriteLine("{0} {1} PESEL: {2} nr konta: {3}", user.name, user.surname, user.pesel, user.account);
            Console.ReadKey();
        }
    }
}
