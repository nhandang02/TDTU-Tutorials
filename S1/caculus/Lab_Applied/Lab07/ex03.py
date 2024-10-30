import sympy as sp
from math import e
import math 

#caua
x = sp.symbols('x')
fa = sp.cos(x)
print(fa)
taylor = fa.series(x, x0=math.pi/3, n=6)
print(taylor)
print()

#caub
x = sp.symbols('x')
fb = sp.log(x)
print(fb)
taylor = fb.series(x, x0=2, n=10)
print(taylor)
print()

#cauc
x = sp.symbols('x')
fc = e**x
print(fc)
taylor = fc.series(x, x0=3, n=12)
print(taylor)
print()