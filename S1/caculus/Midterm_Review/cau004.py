import sympy as sp

x = sp.symbols('x')
N = [0]
f = x**4 - 64*x**2 + 256
for i in range(-10, 0, 1):
    a = f.subs(x, i)
    N.append(a)
print('%.4f'%(max(N)))
    