import sys

def main():
    if len(sys.argv) != 2:
        print("Wrong command: python3 lore_vault.py <BOOK_CODE>.txt")
        sys.exit()
    filename = sys.argv[1]
    list = []
    longest_line = ""
    longest_line_number = 0
    total_len = 0

    try:
        with open(filename, "r") as f:
            for line in f:
                sentence, line_number = line.strip().split("|")
                total_len += len(sentence)
                line_number = int(line_number)
                list.append((sentence, line_number))


                if len(sentence) > len(longest_line):
                    longest_line = sentence
                    longest_line_number = line_number
                elif len(sentence) == len(longest_line) and line_number < longest_line_number:
                    longest_line = sentence
                    longest_line_number = line_number


               


        sorted_list = sorted(list, key = lambda x: x[1])       
        average_len = round(total_len / len(list))

        arr = []
        arr.append(filename.replace(".txt", "") + "\n")
        arr.append(f"Longest line ({longest_line_number}): {longest_line}\n")
        arr.append(f"Average length: {average_len}\n")


        for sentence, _ in sorted_list:
            arr.append(sentence + "\n")
        output_file = filename.replace(".txt", "_book.txt")

        with open(output_file, "w") as f_obj:
            f_obj.writelines(arr)

    except FileNotFoundError:
        print("File cannot be found!")
if __name__ == "__main__":
    main()
