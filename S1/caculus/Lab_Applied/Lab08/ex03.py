import sympy as sp
from sympy.plotting import plot3d

x, y = sp.symbols('x y')

#a
fa = 2*x*x -3*y - 4
dfa_x = fa.diff(x)
print(dfa_x)
dfa_y = fa.diff(y)
print(dfa_y)

plot3d(fa,
        dfa_x,
        (dfa_y, (x,-100, 100), (y, -100, 100))
    )

#b
fb = (x*x - 1) * (y+2)
dfb_x = fb.diff(x)
print(dfa_x)
dfb_y = fb.diff(y)
print(dfb_y)

plot3d(fb,
        dfb_x,
        (dfb_y, (x,-100, 100), (y, -100, 100))
    )

#c
fc = x*x - x*y + y*y
dfc_x = fc.diff(x)
print(dfc_x)
dfc_y = fc.diff(y)
print(dfc_y)

plot3d(fc,
        dfc_x,
        (dfc_y, (x,-100, 100), (y, -100, 100))
    )



#0
fo = sp.log(x+y)
dfo_x = fo.diff(x)
print(dfo_x)
dfo_y = fo.diff(y)
print(dfo_y)

plot3d((fo, (x, 1, 100), (y, 1, 100)),
        (dfo_x, (x, 1, 100), (y, 1, 100)),
        (dfo_y, (x, 1, 100), (y, 1, 100))
    )