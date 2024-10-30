import sympy as sp 
import matplotlib.pyplot as plt 
import numpy as np 

x = sp.symbols('x')

def olot_graph9(f, a, b, xs, ys):
    lx = np.linspace(a, b, 1000)
    ly = [f.subs(x, it).evalf() for it in lx]
    plt.plot(lx, ly)
    plt.show()

#caua
f = x*x - 2*x - 5
f 