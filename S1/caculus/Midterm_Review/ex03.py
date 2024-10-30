f1 = lambda x: x + 5
f2 = lambda x: x**2 - 3

fa = lambda x: f1(f2(x))
fb = lambda x: f2(f1(x))
fc = lambda x: f1(f1(x))
fd = lambda x: f2(f2(x))

print(fa(0))
print(fb(0))
print(fc(-5))
print(fd(2))