import sympy as sp
from sympy.plotting import plot3d
from math import e

x, y = sp.symbols('x y')

#a
f = x + y + x*y

d2f_dx2 = sp.diff(f, x, 2)
d2f_dy2 = sp.diff(f, y, 2)
d2f_dxdy = sp.diff(f, y).diff(x)
d2f_dydx = sp.diff(f, x).diff(y)

print(d2f_dx2)
print(d2f_dy2)
print(d2f_dxdy)
print(d2f_dydx)

plot3d((f, (x, 1, 5), (y, 1, 5)),
        (d2f_dx2, (x, 1, 5), (y, 1, 5)),
        (d2f_dy2, (x, 1, 5), (y, 1, 5)),
        (d2f_dxdy, (x, 1, 5), (y, 1, 5)),
        (d2f_dydx, (x, 1, 5), (y, 1, 5)))

# #h
# f = y * e**(x**2 - y)

# d2f_dx2 = sp.diff(f, x, 2)
# d2f_dy2 = sp.diff(f, y, 2)
# d2f_dxdy = sp.diff(f, y).diff(x)
# d2f_dydx = sp.diff(f, x).diff(y)

# print(d2f_dx2)
# print(d2f_dy2)
# print(d2f_dxdy)
# print(d2f_dydx)

# plot3d((f, (x, 1, 5), (y, 1, 5)),
#         (d2f_dx2, (x, 1, 5), (y, 1, 5)),
#         (d2f_dy2, (x, 1, 5), (y, 1, 5)),
#         (d2f_dxdy, (x, 1, 5), (y, 1, 5)),
#         (d2f_dydx, (x, 1, 5), (y, 1, 5)))

# #b
# f = sp.sin(x*y)

# d2f_dx2 = sp.diff(f, x, 2)
# d2f_dy2 = sp.diff(f, y, 2)
# d2f_dxdy = sp.diff(f, y).diff(x)
# d2f_dydx = sp.diff(f, x).diff(y)

# print(d2f_dx2)
# print(d2f_dy2)
# print(d2f_dxdy)
# print(d2f_dydx)

# plot3d((f, (x, 1, 5), (y, 1, 5)),
#         (d2f_dx2, (x, 1, 5), (y, 1, 5)),
#         (d2f_dy2, (x, 1, 5), (y, 1, 5)),
#         (d2f_dxdy, (x, 1, 5), (y, 1, 5)),
#         (d2f_dydx, (x, 1, 5), (y, 1, 5)))