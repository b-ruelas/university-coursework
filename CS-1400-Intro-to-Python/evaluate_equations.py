"""
In this code I will demostrate the
importance of parenthesis in a mathematical problem

"""

#First equation

n1 = int(input("Enter the fisrt number: "))
n2 = int(input("Enter the second number: "))
n3= int(input("Enter the third number: "))

result1 = n1 + (n2 * n3)
result2 = (n1 + n2)* n3 

print(f"Equation: {n1} + {n2} * {n3}")
print(f"Case 1: {n1} + ({n2} * {n3})= {result1}")
print(f"Case 2: ({n1} + {n2}) * {n3}= {result2}")

#Second equation

n1 = int(input("Enter the fisrt number: "))
n2 = int(input("Enter the second number: "))
n3= int(input("Enter the third number: "))

result1 = float(n1 - (n2 / n3))
result2 = float((n1 - n2) / n3)

print(f"Equation: {n1} - {n2} / {n3}")
print(f"Case 1: {n1} - ({n2} / {n3})= {result1}")
print(f"Case 2: ({n1} - {n2}) / {n3}= {result2}")

#Third equation

n1 = int(input("Enter the fisrt number: "))
n2 = int(input("Enter the second number: "))
n3= int(input("Enter the third number: "))

result1 = n1 * (n2 + n3)
result2 = (n1 * n2) + n3 

print(f"Equation: {n1} * {n2} + {n3}")
print(f"Case 1: {n1} * ({n2} + {n3})= {result1}")
print(f"Case 2: ({n1} * {n2}) + {n3}= {result2}")