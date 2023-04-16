// See https://aka.ms/new-console-template for more information

using CommandPattern.Contcretes;
var light1 = new LightReceiver() { IsActive = false};
var light2 = new LightReceiver() { IsActive = true};

// invoker kumandaya tekabül ediyor.
var invoker = new Invoker(new TurnOnLightCommand(light1), new TurnOffLightCommand(light2)); //burasını arayüzden yapıyoruz.


Console.WriteLine($"ilk ışığın durumu {light1.IsActive}");
invoker.ClickIlkButton();
Console.WriteLine($"ilk ışığın durumu {light1.IsActive}");

Console.WriteLine($"ikinci ışığın durumu {light2.IsActive}");

invoker.CLickIkinciButton();
Console.WriteLine($"ikinci ışığın durumu {light2.IsActive}");

Console.Read();
