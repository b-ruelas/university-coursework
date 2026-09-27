#predefined lists

odds = [11, 33, 55]
evens = [22, 44, 66, 88]

def interleave(odds, evens):
    result = []
    minlenght = min(len(odds), len(evens))

    for i in range(minlenght):
        result.append(odds[i])
        result.append(evens[i])

    if len(odds) > len(evens):
        result.extend(odds[minlenght:])
    elif len(evens) > len(odds):
        result.extend(evens[minlenght:])
        return result
    
interleaved_list = interleave(odds, evens)
print(f"Interleaved list: {interleaved_list}")