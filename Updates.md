
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

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
1. data management...
         
*add user input validation (For example, it may not make sense to allow a vehicle weight of 100,000 kg. 
I can add additional validation to the user input to ensure that it is within reasonable ranges.)
         
*Error handling (The program currently displays a message box when an input value is invalid, 
but it does not provide any information about the specific error. 
To improve the user experience, I can add more detailed error messages to help users correct their input.)

*Units (thr program uses metric units like a km, liters etc. I can add alternative units like a milles and galons)  
*also I can add an alternative types of fuel like a electric, hybrid, gas... and at the same purpose I can add diferit tipes of benzina

*add trip price calculation

2. technical improvements ... 
         
* I CAN USE APIs like google APIs. It can improve the potrntial of my program and help to predict the best speed and route in different parts of trip 
(getting in consideration acceleration frequency, traffic jams, climbs and the rest of the vehicle and route parameters; it can predict a exact range, or something else)
the main problem is getting access at API keys, it can be unaffordable

*  to add saving data between sessions. To allow users to save their calculations, such as writing data to a file or database. done 

* additional calculations: currently the program only calculates the amount of fuel needed for one trip, but it may be useful to add support for additional calculations, such as estimating the cost of fuel for a given distance or determining the optimal fuel consumption rate for a given vehicle. According to porpouse of add an API additional calc. can be done automaticly
    
3. graphical user interface... 
 * The program currently uses a simple form-based interface, but it may be useful to add additional graphical elements such as a chart showing fuel consumption over time or a map showing the user's route.

to cut a long story short it is just some ideas 