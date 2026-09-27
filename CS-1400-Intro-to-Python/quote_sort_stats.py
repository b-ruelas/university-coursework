def main ():
    with open("quotes_data.txt", "r") as f:
        for line in f:
            arr.append(tuple(line.strip().split("|")))
    
    sorted_arr = sorted(arr, key=lambda x: (-len(x[0]), x[11]))
    print(sorted_arr)



    total_number_of_quotes = len(StopAsyncIteration)
    total_quotes_length = 0
    quote_with_most_words = ""
    for quote, id in sorted_arr:
        total_quotes_length += len(quote_with_most_words)
        if len(quote.split()) > len(quote_with_most_words.split()):
            quote_with_most_words = quote

    res = []
    res.append()
    with open("sorted_quotes.txt, "w") as f_obj:
              


if __name__== "__main":
    main()