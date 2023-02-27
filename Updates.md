
Range Calculator  09.02.2023 //v1.0-v1.1
 
1.First form with elements is constructed
2.Basic programe code maked in simple method (instr if, elif...)

Update 1.2 // 19.02.2023
    
1.Conected non local Git 
2.Main porpose is to add OOP principe:
   *created a separate class for the RangeCalculator, which encapsulates the logic for calculating the fuel required.
    *this allows for better separation of concerns and easier maintenance of the code.
3.Optimized the code in Form1 constructor 
   * seted default values
    * added FormLoad events witch set default values

Update 1.3 // 20.02.2023

1.added saving data between sessions via using a file:
       *created a new buttons "save calculation", "load file"
       *SaveFileDialog class to prompt the user for a file name and location to save
       *then creates a StreamWriter object to write the data; used a similar approach with the OpenFileDialog class 
       and a StreamReader object to read the data from the file.

 Big update 1.4(alpha) //27.02.2023
 The concept of the program has changed, now it is something like a diary for the car 

 Added forms: 
1. main form with buttons to go to the desired function
2. Refueling (counts the total cost and writes it into a csv file)
Refueling table (displays table with recorded refuelings). 4.
4. Expense accounting
5. Expense table 
6. Trip cost calculator (needs improvement! The labels are not updated when the button is pressed)
7. Reminders 
8. Statistics (Needs improvement !form does not update labels correctly)

Hidden forms:
1. income from car ownership
2. income table
3. data chart
4. form of calculation by distance of trip and fuel consumption
5. calculator for electric car



-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
1. data management...
         
*Error handling (The program currently displays a message box when an input value is invalid, 
but it does not provide any information about the specific error. 
To improve the user experience, I can add more detailed error messages to help users correct their input.)

*Units (thr program uses metric units like a km, liters etc. I can add alternative units like a milles and galons)  
*also I can add an alternative types of fuel like a electric, hybrid, gas... and at the same purpose I can add diferit tipes of benzina

2. technical improvements ... 
         
* I CAN USE APIs like google APIs. It can improve the potrntial of my program and help to predict the best speed and route in different parts of trip 
(getting in consideration acceleration frequency, traffic jams, climbs and the rest of the vehicle and route parameters; it can predict a exact range, or something else)
the main problem is getting access at API keys, it can be unaffordable
