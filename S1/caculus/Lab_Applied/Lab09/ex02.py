import sympy as sp 

x = sp.symbols('x')

#caua
fa = 3*x**4 - 16*x**3 + 18*x**2 - 9
d1fa = fa.diff()
d2fa = d1fa.diff()

kinds = ['max' if d2fa.subs(x, i).evalf() < 0 else 'min' for i in sp.solve(d1fa)]
print("f' = ", d1fa)
print("f'' = ", d1fa)
print(kinds)
sp.plotting.plot(fa)

#caub
fb = (x+2) / (2*x*x)
d1fb = fb.diff()
d2fb = d1fb.diff()

kinds = ['max' if d2fb.subs(x, i).evalf() < 0 else 'min' for i in sp.solve(d1fb)]
print("f' = ", d1fb)
print("f'' = ", d1fb)
print(kinds)
sp.plotting.plot(fb)

#cauc
fc = -(x**2)/3 + x**2 + 3*x + 4
d1fc = fc.diff()
d2fc = d1fc.diff()

kinds = ['max' if d2fc.subs(x, i).evalf() < 0 else 'min' for i in sp.solve(d1fc)]
print("f' = ", d1fc)
print("f'' = ", d1fc)
print(kinds)
sp.plotting.plot(fc)

#caud
fd = (5*x*x+5) / x
d1fd = fd.diff()
d2fd = d1fd.diff()

kinds = ['max' if d2fd.subs(x, i).evalf() < 0 else 'min' for i in sp.solve(d1fd)]
print("f' = ", d1fd)
print("f'' = ", d1fd)
print(kinds)
sp.plotting.plot(fd)