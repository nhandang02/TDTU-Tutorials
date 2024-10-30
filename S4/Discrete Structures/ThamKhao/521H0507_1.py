def extended_euclid(a, b):
    if a == 0:
        return (b, 0, 1)
    else:
        gcd, x, y = extended_euclid(b % a, a)
        return (gcd, y - (b // a) * x, x)

def inverse_modulo(a, b):
    gcd, x, y = extended_euclid(a, b)
    if gcd != 1:
        return "{} does not have a modular inverse modulo {}".format(a,b)
    else:
        return "inverse_modulo({}, {}) is : {}".format(a,b, x % b)
    
# test
print(inverse_modulo(20, 23))
# Result: inverse_modulo(20, 23) is : 15

print(inverse_modulo(25, 30))
# Result: 25 does not have a modular inverse modulo 30