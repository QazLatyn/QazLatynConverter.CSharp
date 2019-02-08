# QazLatynConverter.Net

## Installation

> # Nuget
> PM> Install-Package QazLatynConverter.Net -Version 1.0.1## Usage
> ```C#
> using QazLatyn;
>
> string cyrlText = "Латын графикасына негізделген қазақ әліпбиінің конвертері";
> string latynText = QazLatynHelper.Cyrl2Latyn(cyrlText);
> Console.WriteLine(latynText);
> ```
