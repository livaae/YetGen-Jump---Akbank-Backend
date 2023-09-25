// See https://aka.ms/new-console-template for more information
using Week1_1.Entities;
using Week1_1.Entities.ComputerComponents;
using Week1_1.Enums;
using Week1_1.ValueObjects;

Console.WriteLine();

Storage storage1 = new Storage("WD Blue", new Capacity(1, CapacitySizeType.TB));


RAM memory1 = new RAM("Corsair", new Capacity(16, CapacitySizeType.GB));
RAM memory2 = new RAM("Corsair", new Capacity(8, CapacitySizeType.GB));

Computer computer1 = new Computer("Apple", "Macbook Pro", "intel i7", memory1, storage1);
Computer computer2 = new Computer("Apple", "Macbook Pro", "intel i5", memory2, storage1);


//Console.WriteLine($"Storage Size: {computer1.Storage.Size} {computer1.Storage.SizeType}");
