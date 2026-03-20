# Week 5: Guess the Number - Study Notes

**Name:** Conner

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do while will always run once, while wont run if its condition is false.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer:i used a do while in the readintinrange to check if the value was true.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: i used a while loop to check if the guess was equal to the secret.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: i used a for loop to loop through all the code needed per round

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer:using a helper method lets us validate input without bloating the program with overused code.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: i checked if it was above or below the max/min and looped if they werent.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: i used the range check method to ensure the number was between 1 and 3

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: if the int.TryParse finds an invalid value it returns 0, restarting the loop.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: i used if/else logic and console.writeline to check if it was too low, too high, and if it was neither, it was correct.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: in the while loop, i used guesscount++ to increase every loop.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: i used random to generate a random number and used next to generate a random value for use

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: random.next will not normally generate the max number, so adding 1 will allow it to generate the maximum number

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: i tried numbers above the max and below the min, as well as letters and non numbers

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: During my testing, i didnt encounter many errors.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. difference between do while vs while
2. how to properly use to helper methods to assist my code
3. remembering for loops for future projects

**Which loop felt most natural to use and why?**

Answer: for loops, as i have used them a lot before

## Time Spent

**Total time:** 1 hour

**Breakdown:**

- Planning the loops: [12 minutes]
- Input validation: [12 minutes]
- Guessing logic: [12 minutes]
- Testing and debugging: [12 minutes]
- Writing documentation: [12 minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Not much took too long, but refining the helper method took a few tries

## Reflection

**What would you do differently next time?**

Answer: I would make my helper method better the first .

**How did using three different loop types improve your understanding of repetition?**

Answer: it helped me know when to use different loops for code efficiency.
