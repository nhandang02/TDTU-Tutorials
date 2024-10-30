import sympy as sp 

x, m = sp.symbols('x m')

x0 =1 
y = x**3 -3*m*x*x + 3*(m*m - 1)*x - (m*m - 1) 
print(y)
dy = y.diff()
print("y' = ", dy)
d2y = dy.diff()
print("y'' ")