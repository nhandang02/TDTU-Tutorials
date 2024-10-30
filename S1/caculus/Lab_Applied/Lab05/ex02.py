import sympy as sp
import math
import matplotlib.pyplot as plt
from sympy.plotting import plot
x = sp.symbols('x')
def draw(fx, y):
    g1 = plot(fx, show=False)
    g2 = plot(fx, show=False)
    g1.append(g2[0])
    g1.show()
#a
fa = x*x +1 
A = (2, 5)
dfa = fa.diff()
print(dfa)
s= dfa.subs(x, A[0])
print(s)
y =s*(x- A[0]) + A[1]
print(y)
draw(fa,y)

#b
fb = x - 2*(x**2) 
B = (1, -1)
dfb = fb.diff()
print(dfb)
s= dfb.subs(x, B[0])
print(s)
y =s*(x- B[0]) + B[1]
print(y)
draw(fb,y)

#c
fc = x / (x-2)
C = (3, 3)
dfc = fc.diff()
print(dfc)
s= dfc.subs(x, C[0])
print(s)
y =s*(x- C[0]) + C[1]
print(y)
draw(fc,y)

#d
fd = 8/(x**2) 
D = (2, 2)
dfd = fd.diff()
print(dfd)
s= dfd.subs(x, D[0])
print(s)
y =s*(x- D[0]) + D[1]
print(y)
draw(fd,y)

#e
fe = sp.sqrt(x) 
E = (4 ,2)
dfe = fe.diff()
print(dfe)
s= dfe.subs(x, E[0])
print(s)
y =s*(x- E[0]) + E[1]
print(y)
draw(fe,y)

#f
ff = x**3 + 3*x
F = (1, 4)
dff = ff.diff()
print(dff)
s= dff.subs(x, F[0])
print(s)
y =s*(x- F[0]) + F[1]
print(y)
draw(ff,y)


#g
fg = 8/ sp.sqrt(x-2)
G = (6, 4)
dfg = fg.diff()
print(dfg)
s= dfg.subs(x, G[0])
print(s)
y =s*(x- G[0]) + G[1]
print(y)
draw(fg,y)


#h
fh = 1 + sp.sqrt(4-x)
H = (3, 2)
dfh = fh.diff()
print(dfh)
s= dfh.subs(x, H[0])
print(s)
y =s*(x- H[0]) + H[1]
print(y)
draw(fh,y)



