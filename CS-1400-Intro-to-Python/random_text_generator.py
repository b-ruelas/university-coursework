"""
This program generates random text made of lowercase words and writes it
to a file. Each line contains 8-10 words, and at least 100 lines are written.

"""

import random 
import string 
import sys 

def make_word(): #This secction will create a random word.

    length = random.randint(5,10)
    word = ''.join(random.choice(string.ascii_lowercase) for _ in range (length))
    return word

def make_line():
    num_words = random.randint(8, 10)
    words = [make_word() for _ in range(num_words)]
    return ' '.join(words)

def write_random_text(filename="randomText.txt", lines=100):
    with open(filename, "w") as file:
        for _ in range (lines):
            file.write(make_line() + "\n")
    print (f"File '{filename}' created with {lines} lines of random text.")

if __name__ == "__main__":
    write_random_text()