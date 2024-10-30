import sympy as sp 
from sympy.plotting import plot3d
from math import e
from sympy import sqrt

x = sp.symbols('x')
y = sp.symbols('y')

#a
fa = sp.cos(x) * sp.cos(y) * (e**(-(sqrt(x**2+y**2))/4))
plot3d(fa)

#b
fb= (-(x*y**2)) / (x**2+y**2) 
plot3d(fb)

#c
fc = (x*y)*(x**2-y**2) / (x**2+y**2)
plot3d(fc)

#d
fd = y**2 - y**4 - x**2
plot3d(fd)