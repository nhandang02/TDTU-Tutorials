import sympy as sp 
import numpy as np 
import math
x = sp.symbols('x')
y = (-2)*(x**2)/3 + x
x0 = 0
dx =sp.symbols('dx')
fx = (y.subs(x, x0+dx) - y.subs(x, x0)) / dx
print(fx)
print(sp.limit(fx, dx, 0))