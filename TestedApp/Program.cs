using TestedApp;

Console.WriteLine("This shouldn't be run during testing.");
Console.WriteLine($"Just an app doing app things. I think {TestableClass.TestableMethod()} is 69");
Console.WriteLine("But how can I know without tests?");