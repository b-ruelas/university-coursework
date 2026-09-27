#!/usr/bin/env python3   



#Name: Brayan Ruelas
#Class: INFO 2200
#Section: M01: Submit Participation 1 – Read/Write & Command-line
#Professor: Chris Fredrickson
#Date: 1/16/26
#Participation or Assignment #: Participation 1
#By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.

def main():
    """
    This main function willd display a the capitol of the state the user enter

    """
    print("Welcome to Ruelas' State Capital Lookup App")#welcome message
    print()#blank space for look
    user_state = input("Please enter a state and I will return the capital (x to exit): ")#get the user state

    statecaps = "" #creates a variable 
    while user_state.lower() != "x":# creates a while loop, if user enter x the loop stops
        with open("statecaps.txt") as file:# this open the text and save it with the name 'file'
            statecapsdic = {}#creates a dictionary
            file.readline()#this reads the each line from the text
            for line in file:#give a comand to look each line in the file 
                line = line.replace("\n", "")#looks the newcharacter 
                temstatecap =line.split(",")#separate the characters when it finds ,
                statecapsdic.update({temstatecap[0]:temstatecap[1]})#update the dictionary 
        
        
        userchoice =user_state.title()#convert user input into a title to match dictionary
        if userchoice in statecapsdic:#condition to check if it is in the dictionary
            print()#black space for look
            print(f"State: {user_state}")#prints a message with user input
            print(f"Capital: {statecapsdic[userchoice]}")#prints the capital accordinf the user state
            print()#blank space for look 
        else:
            print(f"We counld not find {user_state} in the data base")#if there is not a match this will be print
            print()#blank space for look 
        user_state = input("Please enter a state and I will return the capital (x to exit): ")#after the result this will be showing 
    print("Good bye!")#message after user enter x



if __name__ == "__main__": main()