"""
In the context of Exodus: Humanity’s Rebirth, humanity is in the midst of the greatest migration ever attempted: fleeing Earth’s dying surface and traveling toward the new Earth-like planet, Nova Gaia. Onboard the massive generation ships, astronauts, engineers, and colonists must conduct spacewalks to maintain and repair critical systems, navigate asteroid fields, and prepare for future operations on Nova Gaia.

Brownian motion, discovered by botanist Robert Brown, refers to the random, erratic motion of particles suspended in a fluid. This phenomenon was later modeled mathematically and has widespread applications, from physics to financial markets. A random walk is a mathematical model that describes such erratic movements, where each step is determined randomly, often with equal probabilities.

This simulation, Pathfinder Tracker, will model the movements of astronauts during their spacewalks. These astronauts are essential to the survival of the colony. They maintain the ship's outer systems, set up communication arrays, and conduct repairs. Spacewalks are perilous and unpredictable, so understanding and tracking their movements will be vital for both training and mission success.

In this project, you’ll simulate the movements of three astronauts on a spacewalk, each with their own behavior pattern. The data will help monitor their actions, predict their behavior, and ensure that the mission’s objectives can be met despite the random and chaotic environment of deep space.

"""

import matplotlib.pyplot as plt
import random

def dpath(name, marker, color, positions):
    plt.plot(positions[0], positions[1], linestyle='-', marker=marker, color=color)
    plt.title(f"{name}'s SpaceWalk (500 Steps)")
    plt.xlabel('X position')
    plt.ylabel('Y position')
    plt.grid(True)
    plt.axis('equal')
    plt.show()


def astronaut_move(astronaut):
    x, y = 0, 0
    x_positions = [x]
    y_positions = [y]
    step = 500
    for _ in range(step):
        direction = random.choice(astronaut["directions"])
        x += direction[0]
        y += direction[1]
        x_positions.append(x)
        y_positions.append(y)
    
    
    dpath(astronaut["name"], astronaut["marker"], astronaut["color"], (x_positions, y_positions))
    print(f"Final position after {step} steps: ({x}, {y})")


def main():
    
    astronauts = [

        {"name": "Lance", "marker": "o", "color": "blue", "directions": [(0,1), (0,-1), (1,0), (-1,0)]},
        {"name": "Sophie", "marker": "s", "color": "red", "directions": [(0,1), (0,1),(0,1), (0,-1), (1,0), (-1,0)]},
        {"name": "Finn", "marker": "^", "color": "green", "directions": [(1,0), (-1,0)]}

    ]
    for people in astronauts:
        astronaut_move(people)
    


if __name__ == "__main__":
    main()
