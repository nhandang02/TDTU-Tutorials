import sympy as sp 
from sympy import sin
from sympy import cos

x, y = sp.symbols('x y')

#a
fa = x*sin(y) + y*sin(x) + x*y

N1 = fa.subs(x, y)
N2 = fa.subs(y, x)

if N1 - N2 == 0:
    print('fxy = fyx')
else:
    print('fxy != fyx')

#b
fb = sp.log(2*x + 3*y)
N1 = fb.subs(x, y)
N2 = fb.subs(y, x)

if N1 == N2:
    print('fxy = fyx')
else:
    print('fxy != fyx')