import sympy as sp
import numpy as np
import matplotlib.pyplot as plt
#a
x= sp.symbols('x')
y = 1/ (x+2)
z =sp.symbols('z')
fx = (y.subs(x, z)- y.subs(x, x))/ (z-x)
print('cau a:')
print(fx)
print(sp.limit(fx, z, x ))


#b
x= sp.symbols('x')
y = x**2 - 3*x +4
z =sp.symbols('z')
fx = (y.subs(x, z)- y.subs(x, x))/ (z-x)
print('cau b:')
print(fx)
print(sp.limit(fx, z, x ))


#c
x= sp.symbols('x')
y = x / (x-1)
z =sp.symbols('z')
fx = (y.subs(x, z)- y.subs(x, x))/ (z-x)
print('cau c:')
print(fx)
print(sp.limit(fx, z, x ))


#d
x= sp.symbols('x')
y = 1 + x**1/2
z =sp.symbols('z')
fx = (y.subs(x, z)- y.subs(x, x))/ (z-x)
print('cau d:')
print(fx)
print(sp.limit(fx, z, x ))