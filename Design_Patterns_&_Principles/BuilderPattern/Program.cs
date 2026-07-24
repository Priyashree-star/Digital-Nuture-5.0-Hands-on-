using BuilderPatternExample.Models;

Computer gamingPC = new Computer.Builder()
    .SetCPU("Intel i7")
    .SetRAM(16)
    .SetStorage(512)
    .Build();

Console.WriteLine("Gaming PC");
Console.WriteLine("CPU: " + gamingPC.CPU);
Console.WriteLine("RAM: " + gamingPC.RAM + " GB");
Console.WriteLine("Storage: " + gamingPC.Storage + " GB");

Console.WriteLine();

Computer officePC = new Computer.Builder()
    .SetCPU("Intel i3")
    .SetRAM(8)
    .SetStorage(256)
    .Build();

Console.WriteLine("Office PC");
Console.WriteLine("CPU: " + officePC.CPU);
Console.WriteLine("RAM: " + officePC.RAM + " GB");
Console.WriteLine("Storage: " + officePC.Storage + " GB");