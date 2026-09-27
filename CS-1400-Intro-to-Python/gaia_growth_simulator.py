"""
This program will simulate the popyulation growth according
to the logistic equation and writes the results to a tezxt file as well. 
"""

import sys 


def logistic_next(population, growth):
    return growth * population * (1 - population )


def main ():

    initial_population = float(sys.argv[1])
    growth = float(sys.argv[2])
    steps = int (sys.argv[3])
    filename = sys.argv[4]


    populations = [initial_population]

    for i in range(steps):
        next = logistic_next(populations[-1], growth )
        populations.append(next)

    with open(filename, "w") as file:
        for time, pop in enumerate (populations):
            file.write(f"{time}\t{pop: .3f}\n")

if __name__ == "__main__":
    main()