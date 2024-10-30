import numpy as np
import matplotlib.pyplot as plt

f = lambda x: x**2
g = lambda x: x**3

fa = lambda x: f(g(x))
fb = lambda x: g(f(x))
fc = lambda x: g(g(x))

print((fa(1234) + fb(1234) + fc(1234)))

x1 = np.arange(-100, 100.1, 0.1)
y1 = list(map(f, x1))
plt.plot(x1, y1, color = 'red')
plt.grid()
plt.show()

x2 = np.arange(-5, 5.1, 0.1)
y2 = list(map(g, x2))
plt.plot(x2, y2, color = 'blueS')
plt.grid()
plt.show()