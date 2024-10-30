import sympy as sp
import matplotlib.pyplot as plt
import numpy as np
from sympy.plotting import plot
x = sp.symbols('x')

#a
fa = 5*x- 3*(x**2) 
x0 = 1
dfa = fa.diff()
s = dfa.subs(x, x0)
y = s*(x-x0) + fa.subs(x,x0)
print(dfa)
print(y)

#b
fb =  1/ (x-1)
x0 = 3 
dfb = fa.diff()
s = dfb.subs(x, x0)
y = s*(x-x0) + fb.subs(x,x0)
print(dfb)
print(y)

#c
fc = x**3 -2*x -7 
x0 =-2 
dfc = fc.diff()
s = dfc.subs(x, x0)
y = s*(x-x0) + fc.subs(x,x0)
print(dfc)
print(y)

#d
fd = (x -1)/(x+1)
x0 = 0
dfd = fd.diff()
s = dfd.subs(x, x0)
y = s*(x -x0) + fd.subs(x, x0)
print(dfd)
print(y) 