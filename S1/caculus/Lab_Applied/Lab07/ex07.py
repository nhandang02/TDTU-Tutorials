import matplotlib.pyplot as plt 

#caue
n =[1]
a = [1]

for i in range(2, 6, 1):
    n.append(i)
    a.append(5*a[-1] - 3)

print(n)
print(a)
plt.plot(n, a)
plt.show()

#cauf
n =[1]
a = [2]

for i in range(2, 6, 1):
    n.append(i)
    a.append(a[-1] / (a[-1] + 1))

print(n)
print(a)
plt.plot(n, a)
plt.show()