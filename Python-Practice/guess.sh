#!/bin/bash
#I, Brayan Ruelas, affirm that I am the sole author of this script, it is my own original work
#Date: Nov/2025
#Version 1.0


target=$(( RANDOM % 100 + 1 ))

guesses=0
guess=-1

echo "I'm thinking of a number between 1 and 100."

while [ "$guess" -ne "$target" ]; do
    read -p "Enter your guess: " guess
    guesses=$((guesses + 1))

    if [ "$guess" -lt "$target" ]; then
        echo "Higher!"
    elif [ "$guess" -gt "$target" ]; then
        echo "Lower!"
    fi
done

echo "Correct! You guessed it in $guesses guesses."

exit $guesses
 
