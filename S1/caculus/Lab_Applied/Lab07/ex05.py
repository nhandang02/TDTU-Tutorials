import sympy as sp 
from sympy import sqrt
n = sp.symbols('n')

#caua
fa = ((4*n*n) + 1) / (3*n*n+2)
lma = fa.limit(n, sp.oo)
print(lma)

#caub
fb = sp.sqrt(n**2+1 - n)
lmb = fb.limit(n, sp.oo)
print(lmb)

#cauc
fc = (sqrt(2*n+sqrt(n)) - sqrt(2*n+1))
lmc = fc.limit(n, sp.oo)
print(lmc)