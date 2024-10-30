numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9]
a = 0
b = 0
for x in numbers:
    if x % 2 == 0:
     a = a + 1
    else:
     b = b + 1
print('Number of odd numbers:', a)
print('Number of even numbers:',b)    
