Here is a simple Python console application that simulates a memory allocator. It uses a dictionary to keep track of allocated and free blocks of memory.

```python
class MemoryAllocator:
    def __init__(self, size):
        self.memory = [0] * size
        self.blocks = {}

    def allocate(self, size):
        for i in range(len(self.memory)):
            if self.memory[i:i+size] == [0]*size:
                self.blocks[i] = size
                for j in range(size):
                    self.memory[i+j] = 1
                return i
        return -1

    def free(self, index):
        if index in self.blocks:
            size = self.blocks[index]
            for i in range(size):
                self.memory[index+i] = 0
            del self.blocks[index]

def main():
    allocator = MemoryAllocator(100)
    index = allocator.allocate(10)
    print(f'Allocated block at: {index}')
    allocator.free(index)
    print(f'Freed block at: {index}')

if __name__ == "__main__":
    main()
```

In this code, the `MemoryAllocator` class has two methods: `allocate` and `free`. The `allocate` method finds the first block of free memory of the requested size and marks it as allocated, then returns the starting index of the block. If no block of sufficient size is found, it returns -1. The `free` method takes an index and frees the block of memory starting at that index.

The `main` function creates a `MemoryAllocator` with a size of 100, allocates a block of size 10, prints the starting index of the allocated block, frees the block, and then prints the index of the freed block.