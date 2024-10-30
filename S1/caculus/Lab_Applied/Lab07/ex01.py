import math

#caua
fa = lambda n: 4*n + 1
for n in range(10):
    print(fa(n), end = ',')
print()

#caub
fb = lambda n: 3**n
for n in range(10):
    print(fb(n), end = ',')
print()

#cauc
fc = lambda n: n**3
for n in range(10):
    print(fc(n), end =',')
print()

#caud
def fd(n):
    if n==0 or n==1:
        return 1
    return fd(n-1)+fd(n-2)
for n in range(10):
    print(fd(n), end = ',')
