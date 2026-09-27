"""
Write a Python program that manages student scores using a dictionary. 
You'll create, update, access, and remove items using standard dictionary operations.

"""


scorebook = {}

scorebook["Alice"] = 88
scorebook["Bob"] = 75
scorebook["Charlie"] = 93
scorebook["Dana"] = 80

for name, score in scorebook.items():
    print (name, score)

scorebook ["Dana"] = 85
print(f"Updated Dana's score to {scorebook['Dana']}")

scorebook.pop("Bob")
print("Removed Bob from the scorebook")

if scorebook.get("Eve") is None:
    print("Eve not found in scorebook.")
else:
    pass

average = sum(scorebook.values()) / len(scorebook)
print(f"Average score: {average:.2f}")