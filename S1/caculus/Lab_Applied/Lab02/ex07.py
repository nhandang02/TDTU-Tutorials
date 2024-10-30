import numpy as np

T = np.array([15, 30, 45, 60, 75, 100])
N = np.array([30, 50, 70, 75, 100, 120])

for x in T:
    if x in N:
        print(x)       