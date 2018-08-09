# Unity-CSharp7.2-Activator
Enables Mono compiler to use C# 7.2 in Unity 2018.1+ (also supports Visual Studio 2017+ Tools for Unity).

[![license: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

## How to use
Add `Assets/mcs.rsp` to your `Assets` folder.

If you want to use VSTU, also add `Assets/Editor` folder. After deleting all `*.csproj` files, run `Assets > Open C# Project`.

## Restrictions
- The Mono compiler in Unity 2018.1 and 2018.2 cannot recognize some C# 7+ features (local functions, type switches, and so on). So please be careful and use at your own risk.

## Author
Toru Higuruma ([@neofuji](https://github.com/neofuji))
