citizens = int(input("How many citizens: "))

if citizens <= 2:
    print("You must enter 3 or more citizens")
else:
    total_units = float(input("How many total units: "))

    #Shore leave (3 units each, except Mira and Tov)
    shore_leave = (citizens - 2) * 3
    remaining_units = total_units - shore_leave

    # Mira’s share (13% of what’s left)
    mira_share = 0.13 * remaining_units
    remaining_units -= mira_share

    #Tov’s share (11% of what’s left after Mira)
    tov_share = 0.11 * remaining_units
    remaining_units -= tov_share

    #Divide the rest among all citizens (including Mira and Tov)
    crew_share = remaining_units / citizens

    print(f"Mira's share: {mira_share:.2f}")
    print(f"Tov's share: {tov_share:.2f}")
    print(f"Crew's share: {crew_share:.2f}")
