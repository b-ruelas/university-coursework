#This function will look the character you type within the string you enter

string = input("Enter a string: ")
character = input("Enter a character to count: ")

def counting (string, character):
    count = 0
    for letter in string:
        if letter == character:
            count += 1
    return count
result = counting(string, character)
print(f"The character '{character}' appears {result} times in {string}")