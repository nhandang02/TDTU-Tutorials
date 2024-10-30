import sympy as sp 
#a
f = lambda x, y: x**2 + x*y**3
points = [(0, 0),(-1, 1), (2, 3), (-3, -2)]
for p in points:
    print(f(*p))
print()
#b
f = lambda x, y, z: (x-y) / (y**2 + z**2)
points = [(3, -1, 2), (1, 1/2, 1/4), (0, -1/3, 0), (2, 2, 100)]        
for p in points:
    print(f(*p))