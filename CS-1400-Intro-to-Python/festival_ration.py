# Ask the user to prompt the information
colonist = int(input("Enter the number of colonist: ")) 
food = int(input("Enter the total food available: "))

#Converting the data into floats to get decimals
supply = float(food)
ration = float (colonist * 4)
remaining = float (supply - ration)

#Printing the data and using :.2f to make sure to get 2 decimal places
print(f"Original supply:{supply:.2f}")
print(f"Ration allocation (4 units per colonist):{ration:.2f} ")
print(f"Festival stockpile remaining: {remaining:.2f}")