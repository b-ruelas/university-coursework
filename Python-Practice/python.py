from google import genai
from dotenv import load_dotenv
import os
from buddy.personality import BUDDY_PERSONALITY

load_dotenv()

client = genai.Client(api_key=os.getenv("GEMINI_API_KEY"))

chat = client.chats.create(
    model="gemini-3.6-flash",
    config={
        "system_instruction": BUDDY_PERSONALITY
    }
)

print("Buddy: Hey! I'm Buddy. What's up?")
print("Type 'exit' to leave.\n")

while True:

    user_input = input("You: ")

    if user_input.lower() == "exit":
        print("Buddy: Later! 👋")
        break

    response = chat.send_message(
        message=user_input
    )

    print("Buddy:", response.text)