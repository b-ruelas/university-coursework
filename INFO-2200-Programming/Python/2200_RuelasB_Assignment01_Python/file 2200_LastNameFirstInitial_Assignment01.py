#Name: Brayan Ruelas
#Class: INFO 2200
#Section: Assignment 1 - The College Search Form and Console App
#Professor: Chris Fredrickson
#Date: 01/21/25
#Participation or Assignment #: Assigment 1
#By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.

import random 

def main(): #define the main function   
    with open ("college.txt", "r") as file:# open the file in read mode 
        colleges = file.readlines()#new entity and read the file as list
    user_college = input("Enter a college name (x to exit or 'random' for a random college/): ")#ask user to type the college
    print()#blank space 

    while user_college.lower()  != "x":#loop until the user types x
        found = False #check is the college is found

        if user_college.lower() == "random":
            college, city = random.choice(colleges).split(",")
            print(f"Random college is {college} is located in {city}")


        else:
            for line in colleges:#loop in each line of college file
                college, city = line.split(",")#set a new variable college and city for each ,

            if user_college.lower() == college.lower():#match the user entity with the db   
                print(f"{college} is located in {city}")#if its found this will be display  
                found = True#mark that the college was found
                break #stop searchin once the match is found
        
            if not found:#if this was not found
                print("College not found")#message displayed

        user_college = input("Enter a college name (x to exit or 'random' for a random college/): ")#ask user to type the college








if __name__ == "__main__":#close the function 
    main()
