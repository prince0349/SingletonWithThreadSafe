using System.Threading.Tasks;
using static System.Console;
namespace Singleton
{
  class Program
  {
    static void Main(string[] args)
    {
      Parallel.Invoke(() => LogManagerRequest(), () => LogEmployeeRequest());
      ReadLine();
    }

    private static void LogManagerRequest()
    {
      Singleton fromManager = Singleton.SingleInstance;
      fromManager.LogMessage("Request Message from Manager");
    }
    private static void LogEmployeeRequest()
    {
      Singleton fromEmployee = Singleton.SingleInstance;
      fromEmployee.LogMessage("Request Message from Employee");
    }
  }
}
