# Importing the necessary functions from modules.
from random import choice

try:

    items = input("Enter all the items separated by a comma: ")
    
    if "," in items:
    
        itemList = items.split(",")    
        numItems = int(input("Enter the number of items to be selected: "))

        # If the user tries to get an output with more or equal number of items than the items in the input, this error is printed out.
        if numItems >= len(itemList):
            
            print("The number of selected items must be lesser than the number of total items.")
        
        # The main code.    
        else:
            
            selected = []
            
            print("The selected item(s) is/are-:\n\n")
            
            for _ in range(numItems):
            
                item = choice(itemList)
                selected += item
                print(f"\t{item}")
        
    # If a user enters only one item, it gives out this message.
    else:
        
        print("Please enter more than one item.")

# If a user enters an invalid value, the program doesn't crash with an ugly error but gives out this message instead.
except ValueError:
        
    print("Please enter a valid value.")