import matplotlib.pyplot as plt
import numpy as np
import math

#a
def f6_a(x, k):
    return x ** 2 + k
    
def a():
    k = np.array([2, 4, 6, 8, 10, 12])
    x = np.arange(-10, 10 + 0.1, 0.1)

    for ki in k:
        y = []
        for xi in x:
            y.append(f6_a(xi, ki))

        plt.plot(x, y, label = "k=" + str(ki))

    plt.title("Cau 6a")
    plt.legend()
    plt.show()

#b
def f6_b(x, k):
    return (x + k) ** 2

def b():
    k = np.array([2, 4, 6, 8, 10, 12])
    x = np.arange(-10, 10 + 0.1, 0.1)

    for ki in k:
        y = []
        for xi in x:
            y.append(f6_b(xi, ki))

        plt.plot(x, y, label = "k=" + str(ki))

    plt.title("Cau 6b")
    plt.legend()
    plt.show()

#c
def f6_c(x, k):
    return k * math.sqrt(x)

def c():
    k = np.array([1/3, 1, 3, 6])
    x = np.arange(1, 50 + 0.1, 0.1)

    for ki in k:
        y = []
        for xi in x:
            y.append(f6_c(xi, ki))

        plt.plot(x, y, label = "k=" + str(ki))

    plt.title("Cau 6c")
    plt.legend()
    plt.show()

#d
def d():
    f6_d = lambda x: x ** 3

    x = np.arange(-10, 10 + 0.1, 0.1)
    y = np.array( list( map(f6_d, x) ) )

    plt.plot(x, y, label = 'original graph')
    plt.plot(x-1, y-1, label = 'shifted graph')

    plt.title("Cau 6d")
    plt.legend()
    plt.show()

#e
def e():
    f6_e = lambda x: x ** (2 / 3)

    x = np.arange(0.1, 10 + 0.1, 0.1)
    y = np.array( list( map(f6_e, x) ) )

    plt.plot(x, y, label = 'original graph')
    plt.plot(x+1, y-1, label = 'shifted graph')
    
    plt.title("Cau 6e")
    plt.legend()
    plt.show()

#f
def f():
    f6_f = lambda x: 1/2 * (x + 1) + 5

    x = np.arange(-10, 10 + 0.1, 0.1)
    y = np.array( list( map(f6_f, x) ) )

    plt.plot(x, y, label = 'original graph')
    plt.plot(x+1, y-5, label = 'shifted graph')
    
    plt.title("Cau 6f")
    plt.legend()
    plt.show()

#g
def g():
    f6_g = lambda x: 1 / (x ** 2)

    x = np.arange(-10, 10 + 0.1, 0.1)
    y = np.array( list( map(f6_g, x) ) )

    plt.plot(x, y, label = 'original graph')
    plt.plot(x-2, y-1, label = 'shifted graph')
    
    plt.title("Cau 6g")
    plt.legend()
    plt.show()

#h
def h(): 
    f6_h = lambda x: 1 - x**3
    
    x = np.arange(-10, 10 + 0.1, 0.1)
    y = list( map(f6_h, x) )
    yStretched = list( map(f6_h, x/2) ) 

    plt.plot(x, y, label = 'original graph')
    plt.plot(x, yStretched, label = 'stretched horizontally graph')

    plt.title("Cau 6h")
    plt.legend()
    plt.show()

#i
def i(): 
    f6_i = lambda x: (x + 1) ** (1 / 2)

    x = np.arange(0, 10 + 0.1, 0.1)
    y = list( map(f6_i, x) )
    yStretched = list( map(f6_i, x*4) ) 

    plt.plot(x, y, label = 'original graph')
    plt.plot(x, yStretched, label = 'stretched horizontally graph')

    plt.title("Cau 6i")
    plt.legend()
    plt.show()

#j
def j(): 
    f6_j = lambda x: (x + 1) ** (1 / 2)

    x = np.arange(-1, 10 + 0.1, 0.1)
    y = np.array( list( map(f6_j, x) ) )

    plt.plot(x, y, label = 'original graph')
    plt.plot(x, 3*y, label = 'stretched horizontally graph')

    plt.title("Cau 6j")
    plt.legend()
    plt.show()

a()
b()
c()
d()
e()
f()
g()
h()
i()
j()
