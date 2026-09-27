def main():
    with open ("college.txt", "r") as file:
        colleges = file.readlines()
    user_college = input("Enter a college (x to stop): ")

    while user_college.lower() != "x":
        found = False

        for line in colleges:
            college, city = line.split(",")

            if user_college.lower() == college.lower():
                print(f"{college} is located in {city}")
                found = True
                break 

        if not found:
            print("College not found")
                
        user_college = input("Enter a college (x to stop)")












if __name__ == "__main__":
    main()