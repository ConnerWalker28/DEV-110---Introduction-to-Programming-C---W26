# Week 3: Personal Profile Card - Study Notes

**Name:** Conner

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: String, Int, Double and Bool. String is for text, int is for simple nondecimal numbers, double is for more complex decimal numbers, and bool stores a true/false value.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: I used double for certain numbers or values that may include decimals, such as gpa. in terms of gpa, a 3 is very different from a 3.9 and the decimal very much does matter on a 4.0 scale.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I converted the string into lowercase and checked if it was "yes" to convert it.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I organized by the pre set personal, academic and calculated values.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: Birth year, years to graduate, height conversion, honor status and age in months. 

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: It reduces the amount of questions asked and reduces the amount of inputs i have to manage.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: biggest challenge was formatting. 

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: i overcame the challenge by adding printed empty lines between subjects.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: most confusing was also formatting, wasnt sure how to set it up at first.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: string input to a number is as simple as using int/double.parse depending on your desired accuracy.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer:to convert feet to inches without remainder i used simple division, and used modulo to calculate remainder.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: as described, i calculated honor status by checking if they had above a 3.5 gpa.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: i used gpa.toString(F2) to specify the 2 decimal places within the string.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: i used a conditional/ternary operator to assign a true value to the boolean if the string was "yes" and a false if it was "no"

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I spaced out headers, used even lines, and used consise answers.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: i could have calculated bmi, gpa changes, and your half birthday.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: choosing the right data type can serve a very important purpose in keeping your code clean and fast in applications where calculation speed is important.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: This can be used for resume generating, or generating a bio for social media.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. easier ways to make consise code
2. ways to convert data to other types
3. better use of data types

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: String was the hardest, as it can be very easily broken when using parse or converting to booleans.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types can help prevent further errors and speed up my code.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: I used large numbers for ages and other number statistics, long names, and other simple tests.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I encountered bugs around my use of data types with age specifically, and my mistake of using double for age.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I tested a wide range of values for these variables.

## Time Spent

**Total time:** 1 hours

**Breakdown:**

-   Understanding data types and planning variables: [10 minutes]
-   Collecting user input with correct types: [10 minutes]
-   Implementing calculations: [10 minutes]
-   Formatting output: [10 minutes]
-   Testing and debugging: [10 minutes]
-   Writing documentation: [10 minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Most of the work took the same amount of time.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: Use my data types better, and maybe organize the variables better.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Proper data modeling ensures readable, consise code and outputs.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: I would love to model a slingshot distance calculator! or a caloric density calculator.