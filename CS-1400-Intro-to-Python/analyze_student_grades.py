

"""
Write a Python program that stores student names and grades using tuples, 
then analyzes the data to print summary statistics.
"""

def analyze_grades(student_data):
    grades = [grade for name, grade in student_data]
    average = sum(grades)/ len(grades)
    highest_grade = max(grades)
    lowest_grade = min(grades)

    for name, grade in student_data:
        if grade == highest_grade:
            highest_student = name
        if grade == lowest_grade:
            lowest_student = name
    
    return (average, highest_grade, highest_student, lowest_grade, lowest_student)

students = [("Alice", 87), ("Bob", 92), ("Charlie", 78), ("Dana", 85)]
average, highest, highest_student, lowest, lowest_student = analyze_grades(students)

print("Average grade:", round(average, 1))
print("Highest grade:", highest, "(", highest_student, ")")
print("Lowest grade:", lowest, "(", lowest_student, ")")
