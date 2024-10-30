import sympy as sp
import numpy as np
import matplotlib.pyplot as plt
from sympy.plotting import plot
#a
x= sp.symbols('x')
fa = x**3 - 3*x + 1
x0 = 0
dfa = fa.diff()
s= dfa.subs(x, x0)
y = s*(x- x0) + fa.subs(x, x0)
print('cau a:')
print(dfa)
print(y)
#b
k = 9
x0 = sp.sqrt((k + 3) / 3)
y = k*(x -x0) + fa.subs(x, x0)
print('cau b: ')
print(y)

#c
def draw(fx, y):
    g1 = plot(fx, show = False)
    g2 = plot(fx, show = False)
    g1.append(g2[0])
    g1.show()
A = (2/3, -1)
dfa = fa.diff()
print(dfa)
s = dfa.subs(x, A[0])
print(s)
y = s*(x- A[0] + A[1])
print('cau c: ')
print(y)
draw(fa, y)
