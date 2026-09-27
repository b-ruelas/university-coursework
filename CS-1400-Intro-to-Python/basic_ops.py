#This is like a calculator. You eneter 2 numbers and select the operation you want. 

num1 = float(input("Enter the first number: "))
num2 = float(input("Enter the second number: "))
operation = input("Enter operation (+, -, *, /, all): ")


#Definding the operations
if operation == '+':
    addition = num1 + num2
    print(f"Addition: {addition}")
elif operation == '-':
    substraction = num1 - num2
    print(f"Substraction: {substraction}")
elif operation == '*':
    multiplication = num1 * num2
    print(f"Multiplication: {multiplication}")
elif operation == '/':
    if num2 != 0:
        division = num1 / num2
        print(f"Division: {division}")
    else:
        print("Error: You can not divide by zero")
elif operation == 'all':
    print(f"Addition: {num1 + num2}")
    print(f"Subtraction: {num1 - num2}")
    print(f"Multiplication: {num1 * num2}")
    if num2 != 0:
        print(f"Division: {num1 / num2}")
    else:
        print("Division: Error (you can not divide by zero)")
else:
    print("Invalid operation. Please enter +, -, *, /, or all")