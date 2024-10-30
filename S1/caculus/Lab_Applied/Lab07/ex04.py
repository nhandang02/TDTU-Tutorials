import sympy as sp
import math 

x = sp.symbols('x')

#caua
fa = sp.cos(x)
maclaurina = fa.series(x, x0=0, n=6)
print(maclaurina)
print()

#caub
fb = (math.e)**x
maclaurinb = fb.series(x, x0=0, n=12)
print(maclaurinb)
print()

#cauc
fc = 1 / (1-x)
maclaurinc = fc.series(x, x0=0, n=12)
print(maclaurinc)
print()

#caud
fd = sp.atan(x)
maclaurind = fd.series(x, x0=0, n=12)
print(maclaurind)