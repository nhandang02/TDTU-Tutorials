import sympy as sp

# x, y, R, C = sp.symbols('x, y, R, C')

# R = float(input())
# C = x**2 + y**2 
# y1 = -x

# Cy = C.subs(y, y1)

# xAB = sp.solve(Cy-R)

# yA = y1.subs(-x, xAB[0])
# yB = y1.subs(-x, xAB[1])

# print('%.4f'%(xAB[0]))
# print('%.4f'%(xAB[1]))
# print('%.4f'%(yA))
# print('%.4f'%(yB))


x = sp.symbols('x')

k = float(input())
a = float(input())

f = 1 / (2*x-k)

  