"""
Create a Python program that generates a series of numbers using a loop,
stores them in a list,and writes the list to a text file — one number 
per line.
"""

start = int(input("Enter starting number:"))
ending = int(input("Enter ending number:"))
step = int(input("Enter step size:"))

numbers = []
for n in range(start, ending + 1, step):
    numbers.append(n)

with open("number_series.txt", "w") as file:
    for num in numbers:
        file.write(str(num) + "\n")

print(f"Done! {len(numbers)} numebrs have been saved to 'number_series.txt'")