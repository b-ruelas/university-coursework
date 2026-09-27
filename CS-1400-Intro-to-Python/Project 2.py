def encode_message(message, shift):
    result = ""
    for char in message:
        if char.isalpha():
            base = ord('A') if char.isupper() else ord('a')
            result += chr((ord(char) - base + shift) % 26 + base)
        else:
            result += char
    return result


def decode_message(message, shift):
    result = ""
    for char in message:
        if char.isalpha():
            base = ord('A') if char.isupper() else ord('a')
            result += chr((ord(char) - base - shift) % 26 + base)
        else:
            result += char
    return result


def main():
    while True:
        message = input("Enter a message: ")
        shift = int(input("Enter shift value: ")) % 26
        choice = input("Choose (e)ncode or (d)ecode: ").lower()

        if choice == 'e':
            encoded = encode_message(message, shift)
            print(f"\nEncoded message: {encoded}\n")
        elif choice == 'd':
            decoded = decode_message(message, shift)
            print(f"\nDecoded message: {decoded}\n")
        else:
            print("Invalid choice. Please enter 'e' or 'd'.")

        again = input("Do you want to run again? (y/n): ").lower()
        if again != 'y':
            print("Exiting Lexicon Rebuilder 7X. Goodbye!")
            break


if __name__ == "__main__":
    main()
