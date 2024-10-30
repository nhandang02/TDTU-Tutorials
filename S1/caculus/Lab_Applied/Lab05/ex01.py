import sympy as sp
import math
#a
x = sp.symbols('x')
#a
print(sp.diff(4-x**2)) 
#b
print(sp.diff(x-1)**2 + 1)
#c
print(sp.diff(1/x**2)) 
#d
print(sp.diff((1/x)/(2*x)))
#e
print(sp.diff((3*x)**1/2))
#f
print(sp.diff(2*x+1)**1/2)