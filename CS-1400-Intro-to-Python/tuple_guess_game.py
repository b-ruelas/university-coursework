

import random


numbers = tuple(random.randint(1, 20) for _ in range(5))

best_match = 0 

for attempt in range(1, 6):
    guess_input = input(f"Attempt {attempt}: Enter 5 numbers separated by spaces: ")
    
    guess = tuple(int(x) for x in guess_input.split())
    
    match_count = 0
    for i in range(5):
        if guess[i] == numbers[i]:
            match_count += 1
    
    if match_count > best_match:
        best_match = match_count
    
    if guess == numbers:
        print("You guessed correctly!")
        break
    else:
        print(match_count, "numbers matched in the correct position.")

if guess != numbers:
    print("\nSorry! The correct combination was:", numbers)
    match_percent = (best_match / 5) * 100
    print("Your best match was", int(match_percent), "%")
