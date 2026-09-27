def separate_num(numbers):
    evens = [num for num in numbers if num % 2 == 0]
    odds = [num for num in numbers if num %2 != 0]

    return evens, odds


def main ():
    user_numbers = input("Enter integers separated by spaces: ")
    numbers = [int(x) for x in user_numbers.split()]

    evens, odds = separate_num(numbers)

    print(f"\nOriginal list: {numbers}")
    print(f"Odd values: {odds}")
    print(f"Even values: {evens}")

main()