import sympy as sp 

x = sp.symbols('x')
#a
fa = 3*x**4 - 16*x**3 + 18*x**2 - 9
dfa = fa.diff()
x0 = sp.solve(dfa)
print(x0)
for i in sp.solve(dfa):
    print('(%.2f, %.2f)'%(i, fa.subs(x, i).evalf()))
print()

#b
fb = (x+2) / (2*x*x)
dfb = fb.diff()
x0 = sp.solve(fb)
print(x0)
for i in sp.solve(dfb):
    print('(%.2f, %.2f)'%(i, fb.subs(x, i).evalf()))
print()

#c
fc = -(x**2)/3 + x**2 + 3*x + 4
dfc = fc.diff()
x0 = sp.solve(dfb)
print(x0)
for i in sp.solve(dfc):
    print('(%.2f, %.2f)'%(i, fc.subs(x, i).evalf()))
print()

#d
fd = (5*x*x+5) / x
dfd = fd.diff()
x0 = sp.solve(dfd)
print(x0)
for i in sp.solve(dfd):
    print('(%.2f, %.2f)'%(i, fd.subs(x, i).evalf()))
