import sympy as sp 
import math

#caua
a1 = 5
d = 15

n = sp.symbols('n')
an = a1 + (n-1)*d

print(an)
print('a55 = ', an.subs(n, 55))
print(sp.solve(an - 230)[0])


