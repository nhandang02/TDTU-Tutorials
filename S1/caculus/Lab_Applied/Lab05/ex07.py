import sympy as sp 
import math
import numpy as np
import matplotlib.pyplot as plt
x = sp.symbols('x')
#a
x0 = 0
fa = x**3 + 2*x

xs = np.linspace(x0-1/2, x0+3)
ys = [fa.subs(x, it) for it in xs]
plt.plot(xs, ys)

h= sp.symbols('h')
q = (fa.subs(x, x0+h) - fa.subs(x, x0))/h
print(q)
print(sp.limit(q, h, 0))

def drawTangent(h0):
    y = fa.subs(x, x0) + q.subs(h, h0)*(x-x0)
    yts=[y.subs(x, it) for it in xs]
    plt.plot(xs, yts)

for h0 in [3,2,1,1e-5]:
    drawTangent(h0)

plt.show()


#b
x0 =1
fb = x + 5/x

xs = np.linspace(x0-1/2, x0+3)
ys = [fb.subs(x, it) for it in xs]
plt.plot(xs, ys)

h= sp.symbols('h')
q = (fb.subs(x, x0+h) - fb.subs(x, x0))/h
print(q)
print(sp.limit(q, h, 0))

def drawTangent(h0):
    y = fb.subs(x, x0) + q.subs(h, h0)*(x-x0)
    yts=[y.subs(x, it) for it in xs]
    plt.plot(xs, yts)

for h0 in [3,2,1,1e-5]:
    drawTangent(h0)

plt.show()

#c
x0 = math.pi/2
fc = x + sp.sin(2*x)

xs = np.linspace(x0-1/2, x0+3)
ys = [fc.subs(x, it) for it in xs]
plt.plot(xs, ys)

h= sp.symbols('h')
q = (fc.subs(x, x0+h) - fc.subs(x, x0))/h
print(q)
print(sp.limit(q, h, 0))

def drawTangent(h0):
    y = fc.subs(x, x0) + q.subs(h, h0)*(x-x0)
    yts=[y.subs(x, it) for it in xs]
    plt.plot(xs, yts)

for h0 in [3,2,1,1e-5]:
    drawTangent(h0)

plt.show()

#d
x0 = math.pi
fd = sp.cos(x) + 4*sp.sin(2*x)

xs = np.linspace(x0-1/2, x0+3)
ys = [fd.subs(x, it) for it in xs]
plt.plot(xs, ys)

h= sp.symbols('h')
q = (fd.subs(x, x0+h) - fd.subs(x, x0))/h
print(q)
print(sp.limit(q, h, 0))

def drawTangent(h0):
    y = fd.subs(x, x0) + q.subs(h, h0)*(x-x0)
    yts=[y.subs(x, it) for it in xs]
    plt.plot(xs, yts)

for h0 in [3,2,1,1e-5]:
    drawTangent(h0)

plt.show()