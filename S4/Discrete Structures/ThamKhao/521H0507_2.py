import rsa # import library

# Generation public key and private key
(public_key, private_key) = rsa.newkeys(1024)

#print public key
print("public key: {}\n".format(public_key))
print("private key: {}\n".format(private_key))

# plain text
message = "I have waited for this opportunity for more than half a century, to repeat to you once again"

#encrypt
encrypted_message = rsa.encrypt(message.encode(), public_key)

print("encrypt text: {}\n".format(encrypted_message))

#decrypt
decrypted_message = rsa.decrypt(encrypted_message, private_key).decode()

# print decrypted message
print("decrypt message: {}".format(decrypted_message))
print('plain text = decrypt text: {}'.format(message == decrypted_message))