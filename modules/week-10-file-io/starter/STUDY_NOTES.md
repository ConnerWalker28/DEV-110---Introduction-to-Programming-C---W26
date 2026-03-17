# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: File.ReadAllLines returns a list of strings, and i used it to analyse the file line by line

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: Because blank lines would throw errors when attempting to split.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: File.WriteAllLines takes a path and lines, and overwrites the lines in the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: It helps format the lines to write into the selected path

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: FileNotFoundException occurs when the filepath does not lead to a proper .csv file.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: because there are plenty more exceptions that could mean a variety of things other than file not found.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. Reading files with code.
2. Writing to files with code.
3. Formatting strings and lists.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: Update habit, and i took time to research why I couldnt get it to work.

## Time Spent

**Total time:** 1 hour

**Breakdown:**

- Understanding the starter code and CSV formats: 10 minutes
- Implementing LoadHabits: 10 minutes
- Implementing PrintHabits / PrintSummary: 10 minutes
- Implementing AddHabit / UpdateHabit / SaveHabits: 10 minutes
- Testing and debugging: 10 minutes
- Writing study notes: 10 minutes

**Most time-consuming part:**

Answer: None, Took similar amounts of time.
