#ASCII alphabeth: lower from 97 to 122. Upper from 65 to 90


def shift_letter (char, shift):
    ascii_value = ord(char) - ord('a')
    shifted_value = (ascii_value + shift) % 26
    return chr(shifted_value + ord('a'))

def encoded_word (word, shift):
    encoded = ""
    for char in word:
        if char.islower():
            encoded += shift_letter (char, shift)
        else:
            encoded += char
    return encoded

word = input("Enter a word to encode: ")
shift = int(input("Enter a shift value: "))


result = encoded_word(word, shift)

print("Encoded word:", result)