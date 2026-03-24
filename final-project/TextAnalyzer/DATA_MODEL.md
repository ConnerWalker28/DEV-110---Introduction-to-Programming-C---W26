# Final Project — Data Model Planning Template

_Fill this out **before** writing any code. Think through your app's data first._

---

## Scenario (1–2 sentences)

_What does your app do? Who uses it and why?_

My app analyzes a text file and searches it for the most frequent words, longest words, and the count of each words. This would be used to analyze lists of data such as usernames or other programs outputs to find out more.

---

## Inputs (with types)

_List **at least 5** named inputs your app collects or works with. Include the data type for each._

_Example format:_
_- `movieTitle` (string) — the name of the movie the user enters_

- `files` (list) — a list of files pulled from the "texts" file.
- `choices` (list) — a list of choices for what analysis you want.
- `removeword` (string) — a word to remove from each file.
- `allWords` (list) — list of words in each of the files.
- `printchoice` (string) — a yes or no based on whether you would like to print the processed file.

---

## Calculated or Derived Values

_List any values your program computes from the inputs (totals, averages, counts, formatted strings, etc.)._
_If your app doesn't calculate anything, write "None" and explain why._

My program totals the amount of times a certain word is mentioned in the inputted text file.
---

## Outputs (what the user sees)

_Describe what the program displays. Include menu options, summary views, confirmation messages, etc._

My program outputs a series of text files based on what is inputted, and will print these text files if prompted.

---

## Edge Case to Consider (at least 1)

_What could go wrong or behave unexpectedly? How will your app handle it?_

_Examples: file not found, user enters a letter instead of a number, empty list, duplicate entry._

I feel that my program could find issues if there is a file that is too big, or a different file type. This is solved by a custom message to warn the user that no txt file is found.
