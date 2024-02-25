def allocate(self, size):
        for i in range(len(self.memory)):
            if self.memory[i:i+size] == [0]*size:
                self.blocks[i] = size
                for j in range(size):
                    self.memory[i+j] = 1
                return i
        return -1