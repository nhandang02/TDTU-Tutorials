import matplotlib.pyplot as plt
from math import e 

#caua
n = range(-100, 100, 1)
fa = lambda n: 1 - (-2 / e) ** n
a = [fa(i) for i in n]
plt.plot(n, a)
plt.show()

#caue
def fe(n):
    nom = 1
    denom