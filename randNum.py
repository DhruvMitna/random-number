# Importing the nece4ssary functions from modules.
from random import randint

try:

    # Getting the required values from the user.
    start = int(input("Enter the starting number for the range you want the random number to be selected from: "))
    end = int(input("Enter the ending number for the range you want the random number to be selected from: "))

    # Conditions that make sure the program doesn't break if the user enters the starting number greater than the ending number.
    if start < end:

        print(f"The random number is {randint(start, end)}")
        
    elif start > end:
        
        print(f"The random number generated is {randint(end, start)}")
        
    else:
        
        print("Starting and ending number cannot be equal")
     
# If the user enters an invalid value, this message is displayed instead of the program crashing with an ugly error.   
except ValueError:
    
    print("Please enter a valid value.")