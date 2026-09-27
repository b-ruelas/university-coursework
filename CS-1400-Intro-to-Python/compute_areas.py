"""This code will give the user the area of the circle, triangle, and rectangle after 
the user enter the dimentions """


#Cirlce

r = float(input("Enter the radius: "))
a = 3.141592 * (r ** 2)# check decimals 
print(f"The area of the circle with raidus {r} is {a:.4f}")

#Rectangle

w = int(input("Enter the width: "))
h = int(input("Enter the height "))
a = w * h #check the decimals as the result 
print(f"The area of the rectangle {w} x {h} is {a:.4f}")

#Triangle

b = int(input("Enter the base: "))
h = int(input("Enter the height "))
a = b*h/2
print(f"The area of the tringle with base {b} and height {h} is {a:.4f}")