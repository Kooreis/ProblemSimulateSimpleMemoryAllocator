using System;
using System.Collections.Generic;

public class MemoryAllocator
{
    private Dictionary<int, string> memoryBlocks = new Dictionary<int, string>();
    private int nextFreeAddress = 0;
}