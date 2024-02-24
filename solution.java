import java.util.LinkedList;

class Block {
    int size;
    byte[] memory;

    public Block(int size) {
        this.size = size;
        this.memory = new byte[size];
    }
}