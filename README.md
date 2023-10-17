# TransactionResult
common c# object to get a common standard result can be used on methods, classes, API responses, etc

use example code included on the projects as the below example

```csharp
using Microsoft.Extensions.DependencyInjection;
using StandardTransaction;
using StandardTransaction.Example;
using System.Text.Json;


internal class Program
{
    private static void Main(string[] args)
    {
        //setup our DI
        var serviceProvider = new ServiceCollection()
            // Add your services here..
            .AddSingleton<ITestTransaction, TestTransaction>()
            .AddSingleton<ITransactionResults, TransactionResults>()
            .BuildServiceProvider();

        var demoService = serviceProvider.GetRequiredService<ITestTransaction>();

        var result = demoService.EventA();
        // newtonsoft
        //var stringResult = JsonConvert.SerializeObject(result, Formatting.Indented);
        
        // System.Text.Json;
        var stringResult = JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true });

        System.Console.WriteLine("RESULT: \n");
        System.Console.WriteLine(stringResult);
    }
}
```
