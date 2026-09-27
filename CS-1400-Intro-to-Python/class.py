"""# ARC-9 Resource Allocation Program

# Input prompts (must match exactly)
citizens = int(input("How many citizens: "))
units = float(input("How many total units: "))

# Step 1: Pre-allocation (3 units per citizen, except Mira and Tov)
pre_allocation = (citizens - 2) * 3
remaining_units = units - pre_allocation

# Step 2: Mira's share (13% of remaining)
mira_share = remaining_units * 0.13
remaining_units -= mira_share

# Step 3: Tov's share (11% of what remains after Mira)
tov_share = remaining_units * 0.11
remaining_units -= tov_share

# Step 4: Even distribution among all citizens (including Mira and Tov)
crew_share = remaining_units / citizens

# Output (must match exactly, 2 decimal places)
print(f"\nMira's share: {mira_share:.2f}")
print(f"Tov's share: {tov_share:.2f}")
print(f"Crew's share: {crew_share:.2f}")
"""


def greet(name, /, message = 'hello'):
    print(f"{message} {name}")

greet('luis')
greet()