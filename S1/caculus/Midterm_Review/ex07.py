import matplotlib.pyplot as plt
import numpy as np

def draw(fx ,xl ,xr):
    x = np.arange(xl ,xr+0.1 ,0.1)
    y = list(map(fx, x))
    #plt.title()
    plt.plot(x , y)
    plt.show()
    
fa = lambda x: x**3 - x/2
fb = lambda x: x**2 + x/2

plt.title("x^3 - x/2")
draw(fa ,-50 ,50)
plt.title("x^2 + x/2")
draw(fb ,-50 ,50)

print("x^3 - x/2 is one to one funtion")
print("x^2 + x/2 is not one to one function")