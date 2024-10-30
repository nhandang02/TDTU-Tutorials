import math
import numpy as np

def fa(x):
    return 2 + (x*x)/(x*x+4)
def ta():
    value = []
    for x in np.arange(-2, 2.1, 0.1):
        value.append(fa(x))
    return min (value), max (value)
print(ta())

def fb(x):
    return math.sqrt(5*x + 10)
def tb():
    value = []
    for x in np.arange(0, 5.1, 0.1):
        value.append(fb(x))
    return min (value), max (value)
print(tb())

def fc(x):
    return 2 / (x**2 - 16)
def tc():
    value = []
    for x in np.arange(5, 10.1, 0.1):
        value.append(fc(x))
    return min (value), max (value)
print(tc())

def fd(x):
    return x**4 + 3*x*x - 1 
def td():
    value = []
    for x in np.arange(-3, 3.1, 0.1):
        value.append(fd(x))
    return min (value), max (value)
print(td())

def fe(x):
    if x>=0:
        return x
    else:
        return -x
def te():
    value = []
    for x in np.arange(-3, 3.1, 0.1):
        value.append(fe(x))
    return min (value), max (value)
print(te())