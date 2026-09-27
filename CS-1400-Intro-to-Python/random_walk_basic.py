"""
Build a simple simulation of random 2D movement, 
storing positions step-by-step and visualizing the path.

"""

import matplotlib.pyplot as plt
import random


x, y = 0, 0
x_positions, y_positions = [0], [0]
step = 100 
for _ in range(step):
    direction = random.choice(["Up", "Down", "Left", "Right"])
    if direction == "Up":
            y += 1
    elif direction == "Down":
            y -= 1
    elif direction == "Right":
            x += 1
    else:
            x -= 1
    x_positions.append(x)
    y_positions.append(y)

print(f"Final position after 100 steps: {x, y}")


plt.plot(x_positions, y_positions, linestyle='-', marker='o')
plt.title('Astronaut Random Walk (100 Steps)')
plt.xlabel('X position')
plt.ylabel('Y position')
plt.grid(True)
plt.axis('equal')
plt.show()
