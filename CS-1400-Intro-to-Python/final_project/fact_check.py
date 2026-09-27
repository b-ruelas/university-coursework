"""
This code will prove if the statment is true:
 President Bill Clinton said in his speech to the Democratic National Convention in Charlotte in 2012:
“Since 1961, for 52 years now, the Republicans have held the White House 28 years, the Democrats 24. In those 52 years
 our private economy has produced 66 million private-sector jobs.
 So what’s the jobs score? Republicans 24 million, Democrats 42 (million).”


 How to run this code: in the terminal type python3 fact_check.py

"""

import csv

"Reads the file presidents.csv and create a maping dictionary foe each party R, D"
def generate_ref(ref_file):
    output = {}
    with open (ref_file, "r") as f:
        reader = csv.reader(f)
        for row in reader:
            year, party = row[0], row[1]
            output[year] = party
        return output

"This code will look at the file and create a final answer according to the data, to get a final number in each party "

def generate_labor_data(bls_file, ref):
    output = {"D": 0, "R": 0}
    with open (bls_file, "r") as f:
        reader = csv.reader(f)
        for row in reader:
            year, data = row[0], row [1:]
            if year.isdigit():
                party = ref[year]
                number = sum ([int (x) for x in data])
                output[party] += number 
    return output


"This is the main function, will gather all the information andf print it to read "
def main():
    ref_file = "presidents.csv"
    ref = generate_ref(ref_file)
    print(generate_labor_data("BLS_private.csv", ref))




if __name__ == "__main__":
    main()