"""
count_vowels.py
This program reads the file 'randomText.txt' and counts the occurrences
of each vowel (a, e, i, o, u, y), regardless of case.
"""

def count_vowels(file_path="randomText.txt"):

    vowels = "aeiouy"
    counts = {v: 0 for v in vowels}

    try:
        with open(file_path, "r") as file:
            for line in file:
                for char in line.lower():
                    if char in vowels:
                        counts[char] += 1
    except FileNotFoundError:
        print(f"Error: File '{file_path}' not found.")
        return None

    return counts


if __name__ == "__main__":
    
    result = count_vowels()

    if result:
        
        print(
            f"There were {result['a']} a’s, {result['e']} e’s, {result['i']} i’s, "
            f"{result['o']} o’s, {result['u']} u’s, and {result['y']} y’s."
        )
