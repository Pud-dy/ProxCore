[![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome#readme)

<br />

  <h3 align="center">ProxCore</h3>

  <p align="center">
    ProxCore, A simple & easy to use proxy checking library!
    <br />
</p>

## How to use?
```csharp
using ProxCore;

//Single check
if (Check.http(127.0.0.1,80,4000)){ // IP, Port, Timeout, Useragent
  Console.WriteLine("Working Proxy");
} else {
  Console.Writeline("Failed Proxy");
}


// Or use with Parallel
Parallel.ForEach(proxy, new ParallelOptions { MaxDegreeOfParallelism = 5 }, prox =>
        {
        string[] prox = proxy.Split(':');
           if (Check.http(prox[0],Convert.ToInt32(prox[1]),4000)){ // IP, Port, Timeout, Useragent
               Console.WriteLine("Working proxy : " + prox);
            } else {
               Console.Writeline("Failed Proxy : " + prox);
            }
       });
```

## Contact

Join Our discord - [Discord](https://discord.com/invite/4dyp7RUyGe) - Puddy#9294

Project Link: [https://github.com/Pud-dy/ProxCore/](https://github.com/Pud-dy/ProxCore/)


