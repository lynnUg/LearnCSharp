using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class AsyncTask
    {
        public async void PrintPrimaryNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                var result = await getPrimesAsync(i * 100000 + 1, i * 1000000);
                result.ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        public void PrintPrimaryNumbers()
        {
            for (int i = 0; i < 10; i++)
                getPrimes(i * 100000 + 1, i * 1000000)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
         public  int getPrimeCount(int min, int count)
         {
              return ParallelEnumerable.Range(min, count).Count(n=> 
                   Enumerable.Range(2,(int)Math.Sqrt(n)-1).All(i=>
                   n%i>0));
         }
         public  IEnumerable<int> getPrimes(int min, int count)
         {
               return Enumerable.Range(min, count).Where
                 (n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i =>
                   n % i > 0));
         }
          public Task<IEnumerable<int>> getPrimesAsync(int min, int count)
          {
               return Task.Run (()=> Enumerable.Range(min, count).Where
                (n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i =>
                   n % i > 0)));
          }
   
    }
}
