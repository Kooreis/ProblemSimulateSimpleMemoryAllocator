class MemoryAllocator:
    def __init__(self, size):
        self.memory = [0] * size
        self.blocks = {}