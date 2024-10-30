import matplotlib.pyplot as plt
import numpy as np
import math
#cau 1 
f1 = lambda x: (1-(math.fabs(x)-1)**2)**(1/2)
x_array = np.arange(-1,1.1,0.1)
y_array = list(map(f1, x_array))
plt.plot(x_array, y_array, color='magenta')
plt.grid()
plt.show()

#cau 2 
f2 = lambda x: -3 * ((1 - ((math.fabs(x) /2)**(1/2)))**(1/2))
x_array = np.arange(-2,2.1,0.1)
y_array = list(map(f2, x_array))
plt.plot(x_array, y_array, color='red')
plt.grid() 
plt.show()