"Zerin - festival coordinator "
"Lyra - logistics officer"

# Ask the user to prompt the information
colonist = int(input("Enter the number of colonist: ")) 
food = int(input("Enter the total food units available: "))

#Converting the data into floats to get decimals
zerin = float(food * 0.15)
remaining_zering = float (food - zerin)
lyra = float(remaining_zering * 0.10)
remaining_lyra = float (remaining_zering - lyra)
colonist_share = remaining_lyra / colonist

#Printing the data and using :.2f to make sure to get 2 decimal places
print(f"Zerin's share:{zerin:.2f}")
print(f"Lyra shares:{lyra:.2f} ")
print(f"Share per colonist:{colonist_share:.2f}")