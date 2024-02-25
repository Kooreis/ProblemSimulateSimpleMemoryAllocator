public int Allocate(string data)
    {
        memoryBlocks[nextFreeAddress] = data;
        return nextFreeAddress++;
    }