class MemoryAllocator {
    LinkedList<Block> freeBlocks;

    public MemoryAllocator(int totalSize) {
        freeBlocks = new LinkedList<>();
        freeBlocks.add(new Block(totalSize));
    }
}