import math

def fa(x):
    return math.sqrt(x)

def fb(x):
    return x**(1/3)

def fc(x):
    return x**(2/3)

def fd(x):
    return ((x**3)/3) - ((x**2)/2) - 2*x + 1/3

def fe(x):
    return ((2*x*x)-3)/(7*x+4)

def ff(x):
    return (5*x*x+ 8*x - 3) / (3*x*x + 2)

def fg(x):
    return (math.sin(math.radians(x)))

def fh(x):
    return (math.cos(math.radians(x)))

def fi(x):
    return (3**x)

def fj(x):
    return (10**(-x))

def fk(x):
    return (math.e)**x
def fl(x):
    return math.log2(x)

def fm(x):
    return math.log10(x)

def fn(x):
    return math.log(x, math.e)
print( fa(4)) 
print( fb(27))
print( fc(2))
print( fd(0))
print( fe(0))
print( ff(0))
print( fg(90))
print( fh(0))
print( fi(2))
print( fj(2))
print(fk(1))
print(fl(4))
print(fm(100))
print(fn(10))