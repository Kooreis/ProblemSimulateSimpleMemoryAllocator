Here is a simple implementation of a memory allocator in C#. This implementation uses a dictionary to simulate the memory blocks. The key is the memory address and the value is the data stored in the memory block.

```C#
using System;
using System.Collections.Generic;

public class MemoryAllocator
{
    private Dictionary<int, string> memoryBlocks = new Dictionary<int, string>();
    private int nextFreeAddress = 0;

    public int Allocate(string data)
    {
        memoryBlocks[nextFreeAddress] = data;
        return nextFreeAddress++;
    }

    public void Free(int address)
    {
        if (memoryBlocks.ContainsKey(address))
        {
            memoryBlocks.Remove(address);
        }
    }

    public string Read(int address)
    {
        if (memoryBlocks.ContainsKey(address))
        {
            return memoryBlocks[address];
        }
        else
        {
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MemoryAllocator allocator = new MemoryAllocator();

        int address1 = allocator.Allocate("Hello");
        int address2 = allocator.Allocate("World");

        Console.WriteLine(allocator.Read(address1)); // Outputs: Hello
        Console.WriteLine(allocator.Read(address2)); // Outputs: World

        allocator.Free(address1);

        Console.WriteLine(allocator.Read(address1)); // Outputs: null
        Console.WriteLine(allocator.Read(address2)); // Outputs: World
    }
}
```
This program creates a `MemoryAllocator` object and uses it to allocate memory for two strings. It then reads and prints the data stored at the allocated addresses. Finally, it frees the memory at the first address and attempts to read the data at both addresses again.