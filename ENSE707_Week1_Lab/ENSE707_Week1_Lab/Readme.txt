Q3

1. What happens if the opening balance is negative?
Nothing, there is no check
2. What happens if a deposit amount is negative?
It will remove funds as there is no check for invalid input
3. What happens if a withdrawal amount is greater than the balance?
It will go into the negatives
4. Is the transaction fee calculation clearly documented?
No, there were no comments and the value is hardcoded
5. Is the class easy to test?
Kind of but not really, testing currently requires recompilation
6. What functional requirements are missing?
There are no checks for invalid input, While there are methods for depositing funds and withdrawal the user cannot access them.
7. What non-functional quality attributes are relevant?
Commenting is completely absent from the sample code.

Q4

Quality assurance is the process of ensuring a given product is of good quality during development and focuses more on the processes.
Quality control focuses on the quality of the end product, while QA is preventative QC is reactive.


Activities
• Writing coding standards for money calculations - QA
- Doing this is an act of prevention, it outlines what is expected
and acts as a reminder for developers to write clean, reliable code.

• Running unit tests for withdrawal behaviour - QA
- Also preventative, running unit tests suggests that this is still prior to being put into prod.

• Reviewing requirements for ambiguity - QA
- Preventative action, avoiding developer time being wasted on implimenting a feature the wrong way.

• Testing negative deposit input - unclear
- Testing makes me think this is pre prod, therefore it'd be QA, but since there is a prior question about unit tests I'm not entirely certain.

• Analysing repeated transaction defects - QC
- This would likely fall under QC, it sounds like this is issues reported by customers.

• Reporting a failed test case - QA
- 

• Creating a checklist for financial validation rules - QA
- 

• Retesting after fixing withdrawal logic - QC
- Sounds like the feature passed unit testing and was pushed to prod, this case sounds like it was manually tested on production.

Discussion Question
Why is writing tests not enough to guarantee quality?
Writing tests only ensures that the product functions, not that the underlying processes are of quality.
It's like having a handbuilt engine that works but is held together with blue-tac and is using toothpaste instead of oil.
Technically it passes all of the checks to say that it's a working engine but it's a risk actually using it.

Q7

Please identify which quality attributes are improved:

- Readability
- Maintainability
- Testability
- Reliability

Q9

1. Who are the stakeholders for this small banking system?
Their customers
2. What does quality mean to each stakeholder?
For the customers quality means that systems function as required and are reliable
3. Which defects were detected through testing?
Missing checks for overdraft, invalid inputs
4. Which defects could have been prevented through QA activities?
All
5. How did Copilot help?
It didn't :)
6. What Copilot suggestion did you reject or modify, and why?
None, I didn't use copilot
7. What is the difference between QA and QC in this lab?
QA is the process of putting in place measures to avoid incidents in the future, such as implimenting unit testing and security.
QC in this lab mostly included improvements to the code.