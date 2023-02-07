# Distance Converter

### User Interface and Design
This program is a simple utility program used to convert inches, feet, and yards. 
The interface is a small size as to not take up the full screen; after all it is a utility program.
It has a background that displays rulers to go along with the theme.
There is a slightly transparent panel holding the contents of the program together.


### How to Use

Step 1: Input the measurement and it's unit using the textbox and dropdown on the left.
Step 2: Select the unit you wish to convert to by using the dropdown on the right.
Step 3: Press the arrow button in the middle
Step 4: Voila! 


## Under the Hood

Before any conversion takes place, the program converts the strings to doubles using TryParse.
Then the program uses an if statement to check whether the user input is greater than 0 and to check if
the user has selected both units. 
If not the program will display a message box asking the user to ensure they've enter a number greater
than 0 and to ensure that both units are selected. 

Once the input is correct, the program will use a series of else if statements to make the correct calculation
It does this by checking the Combo Box Index and preforming the correct convertion between those units.
For Example: Index[0] is inches, Index[1] is feet, and Index[2] is yards.
             If the user inputs inches to feet, the program will select
             the else if that check if the index of comboBoxA is 0
             and the index of comboBoxB is 1. The calculation in 
             this else if statement would multiply the input by 12.
             
            
Lastly it outputs the result to the second textbox after converting it from a double to a string.  
