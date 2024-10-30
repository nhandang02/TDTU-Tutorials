import numpy as np

N = np.array([15, 21, 45, 150, 210])
T = np.array([32, 67, 65, 21, 15])

for x in N:
    if x in T:
        print(x)