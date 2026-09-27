
"""
Write a Python program to analyze Olympic medal counts using a list of nested tuples.
 Each tuple represents a country and its medal breakdown (gold, silver, bronze). 
 You'll extract information,calculate totals, and rank the countries.
"""

olympic_data = [
("USA", (10, 8, 6)),
("China", (8, 10, 5)),
("Germany", (5, 3, 4)),
("Japan", (6, 5, 7))
]

def analyze_medals(data):
    results = []
    for country, medals in data:
        gold, silver, bronze = medals
        total = gold + silver + bronze
        results.append((country, total))

    results.sort( key=lambda x: x[1], reverse=True)
    return results

ranked = analyze_medals(olympic_data)

print("Total Medak Counts: ")
for i, (country, total) in enumerate(ranked, start=1):
    print(f"{i}. {country} - {total} medals")

most_gold_medals = max(olympic_data, key=lambda x: x[1][0])
print (f" Country with the most fold medals: {most_gold_medals[0]}")