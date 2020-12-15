![GitHub tag (latest by date)](https://img.shields.io/github/v/tag/Pud-dy/ProxCore)
![GitHub all releases](https://img.shields.io/github/downloads/Pud-dy/ProxCore/total)
![GitHub issues](https://img.shields.io/github/issues/Pud-dy/ProxCore)
![GitHub last commit](https://img.shields.io/github/last-commit/Pud-dy/ProxCore)
![License](https://img.shields.io/badge/License-MIT-blue)
![GitHub followers](https://img.shields.io/github/followers/Pud-dy?style=social)
<br />
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://github.com/Pud-dy)
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


