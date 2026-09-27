"""
Write a Python program that uses sets to manage student memberships in two different university clubs. You'll practice basic set
 operations such as union, intersection, difference, and set methods.

"""

coding_club = {"Alice", "Bob", "Charlie", "Dana"}
robotics_club = {"Charlie", "Eve", "Frank", "Bob"}

def intersection(set1, set2):
    res = set()

    for student in set1:
        if student in set2:
            res.add(student)
    return res


def symmetric_difference(set1, set2):
    res = set()

    for student in set1:
        if student not in set2:
            res.add(student)

    for student in set2:
        if student not in set1:
            res.add(student)
    return res

def difference(set1, set2):
    res = set()

    for student in set1:
        if student not in set2:
            res.add(student)
    return res



both =  sorted(list(intersection(coding_club, robotics_club)))
print(f"Students in both clubs:", both)
one = sorted(list(symmetric_difference(coding_club, robotics_club)))
print(f"Students in only one club:", one)
dif = sorted(list(difference(coding_club, robotics_club)))
print(f"Students only in the coding club:", dif)

coding_club.add("Grace")
print("All unique students:", coding_club | robotics_club)

robotics_club.discard("Eve")
