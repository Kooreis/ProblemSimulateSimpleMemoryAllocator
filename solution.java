Here is a simple implementation of a memory allocator in Java. This implementation uses a LinkedList to keep track of free blocks of memory. When a block is allocated, it is removed from the list of free blocks. When a block is freed, it is added back to the list of free blocks.

```java
import java.util.LinkedList;

class Block {
    int size;
    byte[] memory;

    public Block(int size) {
        this.size = size;
        this.memory = new byte[size];
    }
}

class MemoryAllocator {
    LinkedList<Block> freeBlocks;

    public MemoryAllocator(int totalSize) {
        freeBlocks = new LinkedList<>();
        freeBlocks.add(new Block(totalSize));
    }

    public Block allocate(int size) {
        for (Block block : freeBlocks) {
            if (block.size >= size) {
                freeBlocks.remove(block);
                return block;
            }
        }
        return null;
    }

    public void free(Block block) {
        freeBlocks.add(block);
    }
}

public class Main {
    public static void main(String[] args) {
        MemoryAllocator allocator = new MemoryAllocator(1000);
        Block block1 = allocator.allocate(200);
        Block block2 = allocator.allocate(300);
        allocator.free(block1);
        Block block3 = allocator.allocate(100);
    }
}
```

This is a very simple implementation and does not handle cases where the requested size is larger than any available block. In a real-world memory allocator, you would need to handle this case, as well as cases where the memory is fragmented (i.e., the free memory is not all in one contiguous block).