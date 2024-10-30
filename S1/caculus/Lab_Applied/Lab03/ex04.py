import matplotlib.pyplot as plt
import numpy as np
import math

fi = lambda x: -x**3
x_array = np.arange(-10, 10.1, 0.1)
y_array = list( map(fi, x_array) ) 
plt.plot(x_array, y_array, color='blue')
plt.grid()
plt.show()


def fj(x):
    if x!=0:
        return -1 / (x*x)
x_array = np.arange(-10, 10, 0.1)
y_array = list( map(fj, x_array) )
plt.plot(x_array, y_array, color='blue')
plt.grid()
plt.show()

def fk(x):
    if x!=0:
        return (-1) / (x)
x_array = np.arange(-10, 10, 0.1)
y_array = list( map(fk,x_array) )
plt.plot(x_array, y_array, color='blue')
plt.grid()
plt.show()

def fl(x):
    return (1) / abs(x)
x_array = np.arange(-10, 10, 0.1)
y_array = list( map(fk,x_array) )
plt.plot(x_array, y_array, color='blue')
plt.grid()
plt.show()

def fm(x):
    return math.sqrt(abs(x))
x_array = np.arange(-10, 10, 0.1)
y_array = list( map(fk,x_array) )
plt.plot(x_array, y_array, color='red')
plt.grid()
plt.show()

def fn(x):
    return math.sqrt(abs(-x))
x_array = np.arange(-10, 10, 0.1)
y_array = list( map(fk,x_array) )
plt.plot(x_array, y_array, color='yellow')
plt.grid()
plt.show()




print("i, f(x) is decreasing as x-values belong to (-oo, +oo)")
print("f, f(x) is decreasing as x-values belong to (-oo, +oo)")
print("k, f(x) is decreasing as x-values belong to (-oo, +oo)")
print("l, f(x) is decreasing as x-values belong to (-oo, +oo)")
print("m, f(x) is decreasing as x-values belong to (-oo, +oo)")
print("n, f(x) is decreasing as x-values belong to (-oo, +oo)")