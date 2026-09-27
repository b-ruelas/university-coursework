while True:
    option = input("Enter an option ('c' to check, 'q' to quit): ")
    if option == 'q':
        print("Program terminated.")
    break
    elif option == 'c':
        num = int(input("Enter a number: "))
        if num % 2 == 0:
print (f"The number {num} is even")
else:
print(f"The number {num} is odd")
else:
print("Invalid option, try again")
