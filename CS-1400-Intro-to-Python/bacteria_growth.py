def main():
    starting_population = float(input("Enter starting population: "))
    growth = float(input("Enter hourly growth rate: "))
    hours = int(input("Enter number of hours: "))

    population_history = []
    population = starting_population
    population_history.append(round(population, 2))

    for hour in range(1, hours + 1):
        population *= growth
        population = round(population, 2)
        population_history.append(population)

    for hour, pop in enumerate(population_history):
        print(f"Hour {hour}: population = {pop}")

if __name__ == "__main__":
    main()
