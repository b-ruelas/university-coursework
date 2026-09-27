"""
Use Python’s functional programming features—including lambda, map(), filter(), reduce(),
 and function-based comprehensions—to analyze product review scores.
"""



from functools import reduce

ratings = [4, 5, 2, 3, 5, 1, 4, 3, 5, 2, 4]
ref = {5: "Excellent", 4: "Good", 3: "Average", 2: "Poor", 1: "Terrible"}

def generate_recommendation_flags(ratings):
    return [x >= 4 for x in ratings]

def rating_summary(ratings):
    return {x: ratings.count (x) for x in range (1, 6)}



def main():
    description = list(map(lambda x: ref[x], ratings))
    positive_rating = list(filter(lambda x: x >= 4, ratings))
    total = reduce(lambda x, y: x + y, ratings)
    average = total / len(ratings)

    print(f"Original Ratings: {ratings}")
    print(f"Descriptions: {description}")
    print(f"Positive Ratings: {positive_rating}")
    print(f"Average Rating: {average:.2f}")
    print(f"Recommendation Flags: {generate_recommendation_flags(ratings)}")
    print(f"Rating Summary: {rating_summary(ratings)}")

if __name__ == "__main__":
    main()
