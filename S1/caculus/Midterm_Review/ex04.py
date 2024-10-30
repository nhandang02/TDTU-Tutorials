import math
import numpy as np
import matplotlib.pyplot as plt

fi = lambda x : -x**3
x = np.arange(-10, 10.1, 0.1)
y = list(map(fi, x))
plt.plot(x, y, color = 'blue')
plt.grid()
plt.show()

fj = lambda x: -1/(x*x)

x = np.arange(-10, 10.1, 0.1)
y = list(map(fj, x))
plt.plot(x, y, color = 'yellow')
plt.grid()
plt.show()