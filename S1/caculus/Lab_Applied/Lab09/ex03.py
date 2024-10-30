import sympy as sp 

x = sp.symbols('x')

#caua
f = x**3 - 27*x 
R = [0, 5]
print("f = ", f)
print("R = ", R)
df = f.diff()
print("f' = ", df)
lx = sp.solve(df)
print(lx)
lx = [x0 for x0 in lx if R[0] <= x0 and x0 <= R[1]] + [R[0], R[1]]
print(lx)
ly = [f.subs(x, x0) for x0 in lx]
print(ly)
print("max =", max(ly))
print("main =", min(ly))
print()

#caub
f = 1/2*x**4 - 4*x*x + 5
R = [1, 3]
print("f = ", f)
print("R = ", R)
df = f.diff()
print("f' = ", df)
lx = sp.solve(df)
print(lx)
lx = [x0 for x0 in lx if R[0] <= x0 and x0 <= R[1]] + [R[0], R[1]]
print(lx)
ly = [f.subs(x, x0) for x0 in lx]
print(ly)
print("max =", max(ly))
print("main =", min(ly))
print()

#cauc
f = 3/2*x**4 - 4*x**3 + 4
R = [0, 3]
print("f = ", f)
print("R = ", R)
df = f.diff()
print("f' = ", df)
lx = sp.solve(df)
print(lx)
lx = [x0 for x0 in lx if R[0] <= x0 and x0 <= R[1]] + [R[0], R[1]]
print(lx)
ly = [f.subs(x, x0) for x0 in lx]
print(ly)
print("max =", max(ly))
print("main =", min(ly))
print()

#caud
f = 5/4*x**4 - 20/3*x**3 + 6
R = [-1, 3]
print("f = ", f)
print("R = ", R)
df = f.diff()
print("f' = ", df)
lx = sp.solve(df)
print(lx)
lx = [x0 for x0 in lx if R[0] <= x0 and x0 <= R[1]] + [R[0], R[1]]
print(lx)
ly = [f.subs(x, x0) for x0 in lx]
print(ly)
print("max =", max(ly))
print("main =", min(ly))