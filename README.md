# DurableFunctionsTypedSafeActivities

This is a project to test out an idea for creating extension methods to make the syntax for calling 

By default, the way to invoke activities is by specifying the function name as a string

```csharp
    // Standard way to invoke
    outputs.Add(await context.CallActivityAsync<string>("Function1_Hello", "Tokyo"));
    outputs.Add(await context.CallActivityAsync<string>("Function1_Hello", "Seattle"));
    outputs.Add(await context.CallActivityAsync<string>("Function1_Hello", "London"));
```

There is a T4 template (heavily based on [T4MVC](https://github.com/T4MVC/T4MVC)) that inspects the current project open in Visual Studio and generates a set of extension methods to make the syntax for calling friendlier (and type-safe so that you get compiler errors)

```csharp
    // Invoke using extension method helper
    outputs.Add(await context.SayHello("Tokyo"));
    outputs.Add(await context.SayHello("Seattle"));
    outputs.Add(await context.SayHello("London"));
```

## Thoughts

* still needs work, e.g. generating the right namespace
* needs more thought around which parameters to include. Currently just hard-coded to ignore `TextWriter`
* only works in Visual Studio - is there an alternative to T4 Templates that works outside of VS and xplat?

Also considering moving the methods to a helper to avoid name clashes and make it easier to navigate activity methods as below. This does make the syntasx a bit more verbose, but it is still shorter than the original and has the benefits of code completion and compiler checking.


```csharp
    // Invoke using extension method helper
    outputs.Add(await context.Activities().SayHelloAsync("Tokyo"));
    outputs.Add(await context.Activities().SayHelloAsync("Seattle"));
    outputs.Add(await context.Activities().SayHelloAsync("London"));
```