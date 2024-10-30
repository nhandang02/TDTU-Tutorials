import sympy as sp
import math
from math import sqrt
from math import pi


n = sp.symbols('n')

#caua 
a = 1 - 0.2**n
print(a)
print(sp.limit_seq(a, n))

#caub
b = (n**3) / (n**3+1)
print(b)
print(sp.limit_seq(b, n))

#cauc 
c = (3+5*n*n) / (n+n*n)
print(c)
print(sp.limit_seq(c, n))

#caud
d = n**3 / (n+1)
print(d)
print(sp.limit_seq(d, n))

#caue
e = (math.e)**(1/n)
print(e)
print(sp.limit_seq(e, n))

#cauf
f = sqrt((n+1) / (9*n+1))
print(f)
print(sp.limit_seq(f, n))

#caug
g = (n*(-1)**(n+1)) / (n+sqrt(n))
print(g)
print(sp.limit_seq(g, n))

#cauh
h = sp.tan((2*n*pi) / (1+8*n))
print(h)
print(sp.limit_seq(h, n))

#caui
i = (sp.factorial(2*n-1)) / (sp.factorial(2*n+1))
print(i)
print(sp.limit_seq(i, n))

#cauj
j = sp.log(2*n*n+1) - sp.log(n*n+1)
print(j) 
print(sp.limit_seq(j, n))