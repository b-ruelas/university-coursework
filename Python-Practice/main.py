import os
from imap_tools import MailBox

MAIL_PASSWORD = os.environ["MAIL_PASSWORD"]  # Gmail app password, set as an environment variable
MAIL_USERNAME = os.environ["MAIL_USERNAME"]

with MailBox("imap.gmail.com").login(MAIL_USERNAME, MAIL_PASSWORD, "inbox") as mb:
    print(mb.folder.list())
    print(mb.folder.get())
    for msg in mb.fetch(limit=2, reverse=True,  mark_seen=True):
        print(msg.subject, msg.date, msg.flags, msg.text, msg.uid)

 