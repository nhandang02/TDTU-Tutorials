import sympy as sp 
x = sp.symbols('x')
def getLimit(fx, x0):
    dx = sp.symbols('dx')
    g = (fx.subs(x, x0+dx) - fx.subs(x, x0)) / dx
    return sp.limit(g, dx, 0)
#a
fa = 4 - x**2
for x0 in [-3, 0,1]:
    print(getLimit(fa, x0))

#b
fb = (x-1)**2 + 1
for x0 in [-1, 0,2]:
    print(getLimit(fb, x0))

#c
fc = 1/(x**2)
for x0 in [-1, 2,3**1/2]:
    print(getLimit(fc, x0))
    
#d
fd = (1-x)/(2*x)
for x0 in [-1, 1,2**1/2]:
    print(getLimit(fd, x0))
